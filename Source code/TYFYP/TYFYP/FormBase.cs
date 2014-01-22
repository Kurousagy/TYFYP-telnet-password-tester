using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//# Custom libs:
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace TYFYP
{
    public partial class FormBase : Form
    {
        //# Main thread var:
        Thread main_thread;


        public FormBase()
        {
            InitializeComponent();
        }

        //# ###
        //#     Private methods
        //# ###

        //# isIPv4 method from: http://stackoverflow.com/questions/5096780/ip-address-validation 
        private bool isIPv4(string ipAddress)
        {
            return Regex.IsMatch(ipAddress, @"^\d{1,3}(\.\d{1,3}){3}$") && ipAddress.Split('.').SingleOrDefault(s => int.Parse(s) > 255) == null;
        }

        private void routerTelnetConnection(Router router, bool telnet, bool enable)
        {
            //# Select the router item in listview:
            ListViewItem router_item = null;
            foreach (ListViewItem item in listViewResults.Items)
            {
                if (item.Tag == router) { router_item = item; break; }
            }

            //# If there is not connection to telnet service, I mark it as red line on listview.
            if (!telnet) { router_item.BackColor = Color.Crimson; }
            //# If there is telnet connection, I mark it green telnet column and enable column if proceed.
            else
            {
                router.telnet_connection_available = true;
                router_item.BackColor = Color.PaleGreen;
                if (!enable) {
                    router_item.UseItemStyleForSubItems = false;
                    router_item.SubItems[0].BackColor = Color.PaleGreen;
                    router_item.SubItems[1].BackColor = Color.PaleGreen;
                    router_item.SubItems[2].BackColor = Color.PaleGreen;
                    router_item.SubItems[3].BackColor = Color.Crimson;
                }
                else { router.enable_command_available = true; }
            }
            
        }

        private void mainThreadForTelnetConnections(object target_routers)
        {
            List<Router> list_of_target_routers = (List<Router>)target_routers;

            foreach (Router router in list_of_target_routers)
            {
                ListViewItem router_item = null;
                foreach (ListViewItem item in listViewResults.Items)
                {
                    if (item.Tag == router) { router_item = item; item.BackColor = Color.Bisque; item.EnsureVisible(); break; }
                }
                string router_ip = router_item.SubItems[0].Text;
                labelStatus.Text = "Trying to connect to: " + router_ip;
                Application.DoEvents();

                Telnet telnet = new Telnet(router.ip, 23, 5);

                if (telnet.Connect() == false)
                {
                    router_item.BackColor = Color.Red;
                    labelStatus.Text = "Can't connect to: " + router_ip;
                    Application.DoEvents();
                }
                else
                {
                    try
                    {
                        telnet.WaitFor("Username:");
                        telnet.SendMessage(router.telnet_user);
                    }
                    catch (TimeoutException) { }
                    catch (Exception) { }

                    try
                    {
                        telnet.WaitFor("Password:");
                        telnet.SendMessage(router.telnet_password);
                    }
                    catch (TimeoutException) { }
                    catch (Exception) { }

                    bool connected = false;
                    try
                    {
                        telnet.WaitFor(">");
                        connected = true;
                    }
                    catch (TimeoutException) { }
                    catch (Exception) { }

                    if (connected)
                    {
                        labelStatus.Text = "Connected to: " + router_ip + "! Trying enable password...";
                        labelVulnerableRouters.Text = (Convert.ToInt32(labelVulnerableRouters.Text) + 1).ToString();
                        Application.DoEvents();

                        bool enable_password_works = false;
                        try
                        {
                            telnet.SendMessage("enable");
                            telnet.WaitFor("Password:");
                            telnet.SendMessage(router.enable_password);
                            telnet.WaitFor("#");
                            enable_password_works = true;
                        }
                        catch (TimeoutException) { }
                        catch (Exception) { }

                        routerTelnetConnection(router, true, enable_password_works);
                    }
                    else
                    {
                        routerTelnetConnection(router, false, false);
                    }
                    
                    telnet.Disconnect();
                    telnet = null;
                }

                Application.DoEvents();
                Thread.Sleep(100);
            }
            this.Cursor = Cursors.Default;
            buttonRun.Text = "Run";
            labelStatus.Text = "Work done, Master!";
        }

        //# ###
        //#     Private events
        //# ###

        private void FormBase_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog() { Title = "Select a text file that contains a IP list", Filter = "Text Files (*.txt)|*.txt" };
            if (dialog.ShowDialog() == DialogResult.OK) { textBoxIPsFile.Text = dialog.FileName; }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (buttonRun.Text == "Stop")
            {
                main_thread.Abort();
                main_thread = null;
                buttonRun.Text = "Run";
                this.Cursor = Cursors.Default;
                labelStatus.Text = "Successfully stopped";
                return;
            }
            if (!File.Exists(textBoxIPsFile.Text)) { MessageBox.Show("Can't read IPs file.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            //# Clearing workspace:
            listViewResults.Items.Clear();
            labelStatus.Text = "Woho! Loading bullets...";
            Application.DoEvents();

            //# Target ip list:
            List<Router> list_of_target_routers = new List<Router>();

            //# Read file looking for target ips:
            using (StreamReader sr = new StreamReader(textBoxIPsFile.Text, Encoding.Default))
            {
                //# Possible improvement for next version: be able to read telnet user, password and enable password directly from IP list txt.
                var telnet_user = textBoxTelnetUser.Text;
                var telnet_password = textBoxTelnetPassword.Text;
                var enable_password = textBoxEnablePassword.Text;
                var router_ip = string.Empty;
                while ((router_ip = sr.ReadLine()) != null)
                {
                    if (isIPv4(router_ip))
                    {
                        Router router = new Router(router_ip, telnet_user, telnet_password, enable_password);
                        list_of_target_routers.Add(router);

                        ListViewItem viewitem = new ListViewItem(router_ip);
                        viewitem.SubItems.Add(telnet_user);
                        viewitem.SubItems.Add(telnet_password);
                        viewitem.SubItems.Add(enable_password);
                        viewitem.Tag = router;
                        listViewResults.Items.Add(viewitem);
                    }
                }
            }

            if (listViewResults.Items.Count > 0) { labelStatus.Text = "Bullets are ready! Shooting now..."; Application.DoEvents(); }
            else { labelStatus.Text = "No targets detected :-("; return; }

            //# Launching main and unique thread for all telnet conections. 
            //# This could be upgraded to a multithreaded application, but this is a really simple app and performance is not the target.
            main_thread = new Thread(new ParameterizedThreadStart(mainThreadForTelnetConnections));
            main_thread.Start(list_of_target_routers);
            GC.KeepAlive(main_thread);

            buttonRun.Text = "Stop";
            this.Cursor = Cursors.WaitCursor;
        }
    }
}
