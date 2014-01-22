using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYFYP
{
    class Router
    {
        public string ip { get; set; }
        public string telnet_user { get; set; }
        public string telnet_password { get; set; }
        public string enable_password { get; set; }
        public bool telnet_connection_available { get; set; }
        public bool enable_command_available { get; set; }

        public Router(string ip, string telnet_user, string telnet_password, string enable_password)
        {
            this.ip = ip;
            this.telnet_user = telnet_user;
            this.telnet_password = telnet_password;
            this.enable_password = enable_password;
            this.telnet_connection_available = false;
            this.enable_command_available = false;
        }
    }
}
