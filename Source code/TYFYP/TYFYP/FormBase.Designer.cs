namespace TYFYP
{
    partial class FormBase
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxEnablePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.textBoxTelnetPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTelnetUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIPsFile = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelVulnerableRouters = new System.Windows.Forms.Label();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnableColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxEnablePassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonRun);
            this.groupBox1.Controls.Add(this.textBoxTelnetPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxTelnetUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonSelect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxIPsFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // textBoxEnablePassword
            // 
            this.textBoxEnablePassword.Font = new System.Drawing.Font("Verdana", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnablePassword.Location = new System.Drawing.Point(288, 208);
            this.textBoxEnablePassword.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxEnablePassword.Name = "textBoxEnablePassword";
            this.textBoxEnablePassword.Size = new System.Drawing.Size(354, 46);
            this.textBoxEnablePassword.TabIndex = 9;
            this.textBoxEnablePassword.Text = "password";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enable password:";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(651, 150);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(190, 104);
            this.buttonRun.TabIndex = 7;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // textBoxTelnetPassword
            // 
            this.textBoxTelnetPassword.Font = new System.Drawing.Font("Verdana", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelnetPassword.Location = new System.Drawing.Point(288, 150);
            this.textBoxTelnetPassword.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxTelnetPassword.Name = "textBoxTelnetPassword";
            this.textBoxTelnetPassword.Size = new System.Drawing.Size(354, 46);
            this.textBoxTelnetPassword.TabIndex = 6;
            this.textBoxTelnetPassword.Text = "password";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telnet password:";
            // 
            // textBoxTelnetUser
            // 
            this.textBoxTelnetUser.Font = new System.Drawing.Font("Verdana", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelnetUser.Location = new System.Drawing.Point(288, 92);
            this.textBoxTelnetUser.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxTelnetUser.Name = "textBoxTelnetUser";
            this.textBoxTelnetUser.Size = new System.Drawing.Size(354, 46);
            this.textBoxTelnetUser.TabIndex = 4;
            this.textBoxTelnetUser.Text = "admin";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telnet user:";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(651, 34);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(190, 46);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of IPs:";
            // 
            // textBoxIPsFile
            // 
            this.textBoxIPsFile.Font = new System.Drawing.Font("Verdana", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIPsFile.Location = new System.Drawing.Point(288, 34);
            this.textBoxIPsFile.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxIPsFile.Name = "textBoxIPsFile";
            this.textBoxIPsFile.Size = new System.Drawing.Size(354, 46);
            this.textBoxIPsFile.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelVulnerableRouters);
            this.groupBox2.Controls.Add(this.listViewResults);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 607);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // labelVulnerableRouters
            // 
            this.labelVulnerableRouters.Location = new System.Drawing.Point(282, 565);
            this.labelVulnerableRouters.Name = "labelVulnerableRouters";
            this.labelVulnerableRouters.Size = new System.Drawing.Size(284, 38);
            this.labelVulnerableRouters.TabIndex = 11;
            this.labelVulnerableRouters.Text = "0";
            // 
            // listViewResults
            // 
            this.listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.EnableColumn});
            this.listViewResults.FullRowSelect = true;
            this.listViewResults.Location = new System.Drawing.Point(6, 39);
            this.listViewResults.MultiSelect = false;
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(843, 510);
            this.listViewResults.TabIndex = 10;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Router IP";
            this.columnHeader1.Width = 265;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "User";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Password";
            this.columnHeader3.Width = 190;
            // 
            // EnableColumn
            // 
            this.EnableColumn.Text = "Enable";
            this.EnableColumn.Width = 190;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 565);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vulnerable routers:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.labelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 903);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(879, 40);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(87, 35);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(367, 35);
            this.labelStatus.Text = "Waiting for your order, Master...";
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 943);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 10.17801F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormBase";
            this.Text = "TYFYP: Massive telnet password tester";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox textBoxTelnetPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTelnetUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIPsFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxEnablePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelVulnerableRouters;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader EnableColumn;
    }
}

