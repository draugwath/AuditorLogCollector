namespace AuditorLogCollector
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adBox = new System.Windows.Forms.GroupBox();
            this.adfsChBox = new System.Windows.Forms.CheckBox();
            this.groupPolicyChBox = new System.Windows.Forms.CheckBox();
            this.logonActivityChBox = new System.Windows.Forms.CheckBox();
            this.activeDirectoryChBox = new System.Windows.Forms.CheckBox();
            this.cloudBox = new System.Windows.Forms.GroupBox();
            this.azureADChBox = new System.Windows.Forms.CheckBox();
            this.spoChBox = new System.Windows.Forms.CheckBox();
            this.vmwareChBox = new System.Windows.Forms.CheckBox();
            this.teamsChBox = new System.Windows.Forms.CheckBox();
            this.exoChBox = new System.Windows.Forms.CheckBox();
            this.microsoftBox = new System.Windows.Forms.GroupBox();
            this.sharePointOnPremChBox = new System.Windows.Forms.CheckBox();
            this.exchOnPremChBox = new System.Windows.Forms.CheckBox();
            this.microsoftServersBox = new System.Windows.Forms.GroupBox();
            this.ndcIntegrationChBox = new System.Windows.Forms.CheckBox();
            this.fileServerChBox = new System.Windows.Forms.CheckBox();
            this.uavrChBox = new System.Windows.Forms.CheckBox();
            this.windowsServerChBox = new System.Windows.Forms.CheckBox();
            this.sqlBox = new System.Windows.Forms.GroupBox();
            this.oracleChBox = new System.Windows.Forms.CheckBox();
            this.microsoftSQLChBox = new System.Windows.Forms.CheckBox();
            this.toolsBox = new System.Windows.Forms.GroupBox();
            this.networkDevicesChBox = new System.Windows.Forms.CheckBox();
            this.syslogChBox = new System.Windows.Forms.CheckBox();
            this.penChBox = new System.Windows.Forms.CheckBox();
            this.elmChBox = new System.Windows.Forms.CheckBox();
            this.iutChBox = new System.Windows.Forms.CheckBox();
            this.systemLogs = new System.Windows.Forms.GroupBox();
            this.configAdmConsole = new System.Windows.Forms.CheckBox();
            this.configChBox = new System.Windows.Forms.CheckBox();
            this.collectTrace = new System.Windows.Forms.Button();
            this.healthLogsButton = new System.Windows.Forms.Button();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.adBox.SuspendLayout();
            this.cloudBox.SuspendLayout();
            this.microsoftBox.SuspendLayout();
            this.microsoftServersBox.SuspendLayout();
            this.sqlBox.SuspendLayout();
            this.toolsBox.SuspendLayout();
            this.systemLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // adBox
            // 
            this.adBox.Controls.Add(this.adfsChBox);
            this.adBox.Controls.Add(this.groupPolicyChBox);
            this.adBox.Controls.Add(this.logonActivityChBox);
            this.adBox.Controls.Add(this.activeDirectoryChBox);
            this.adBox.Location = new System.Drawing.Point(12, 102);
            this.adBox.Name = "adBox";
            this.adBox.Size = new System.Drawing.Size(298, 127);
            this.adBox.TabIndex = 2;
            this.adBox.TabStop = false;
            this.adBox.Text = "Active Directory collectors";
            this.adBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // adfsChBox
            // 
            this.adfsChBox.AutoSize = true;
            this.adfsChBox.Location = new System.Drawing.Point(9, 99);
            this.adfsChBox.Name = "adfsChBox";
            this.adfsChBox.Size = new System.Drawing.Size(69, 20);
            this.adfsChBox.TabIndex = 0;
            this.adfsChBox.Text = "AD-FS";
            this.adfsChBox.UseVisualStyleBackColor = true;
            // 
            // groupPolicyChBox
            // 
            this.groupPolicyChBox.AutoSize = true;
            this.groupPolicyChBox.Location = new System.Drawing.Point(9, 73);
            this.groupPolicyChBox.Name = "groupPolicyChBox";
            this.groupPolicyChBox.Size = new System.Drawing.Size(106, 20);
            this.groupPolicyChBox.TabIndex = 0;
            this.groupPolicyChBox.Text = "Group Policy";
            this.groupPolicyChBox.UseVisualStyleBackColor = true;
            // 
            // logonActivityChBox
            // 
            this.logonActivityChBox.AutoSize = true;
            this.logonActivityChBox.Location = new System.Drawing.Point(9, 47);
            this.logonActivityChBox.Name = "logonActivityChBox";
            this.logonActivityChBox.Size = new System.Drawing.Size(112, 20);
            this.logonActivityChBox.TabIndex = 0;
            this.logonActivityChBox.Text = "Logon Activity";
            this.logonActivityChBox.UseVisualStyleBackColor = true;
            // 
            // activeDirectoryChBox
            // 
            this.activeDirectoryChBox.AutoSize = true;
            this.activeDirectoryChBox.Location = new System.Drawing.Point(9, 21);
            this.activeDirectoryChBox.Name = "activeDirectoryChBox";
            this.activeDirectoryChBox.Size = new System.Drawing.Size(123, 20);
            this.activeDirectoryChBox.TabIndex = 0;
            this.activeDirectoryChBox.Text = "Active Directory";
            this.activeDirectoryChBox.UseVisualStyleBackColor = true;
            // 
            // cloudBox
            // 
            this.cloudBox.Controls.Add(this.azureADChBox);
            this.cloudBox.Controls.Add(this.spoChBox);
            this.cloudBox.Controls.Add(this.vmwareChBox);
            this.cloudBox.Controls.Add(this.teamsChBox);
            this.cloudBox.Controls.Add(this.exoChBox);
            this.cloudBox.Location = new System.Drawing.Point(12, 317);
            this.cloudBox.Name = "cloudBox";
            this.cloudBox.Size = new System.Drawing.Size(299, 150);
            this.cloudBox.TabIndex = 3;
            this.cloudBox.TabStop = false;
            this.cloudBox.Text = "Cloud collectors";
            // 
            // azureADChBox
            // 
            this.azureADChBox.AutoSize = true;
            this.azureADChBox.Location = new System.Drawing.Point(9, 21);
            this.azureADChBox.Name = "azureADChBox";
            this.azureADChBox.Size = new System.Drawing.Size(85, 20);
            this.azureADChBox.TabIndex = 0;
            this.azureADChBox.Text = "Azure AD";
            this.azureADChBox.UseVisualStyleBackColor = true;
            // 
            // spoChBox
            // 
            this.spoChBox.AutoSize = true;
            this.spoChBox.Location = new System.Drawing.Point(9, 47);
            this.spoChBox.Name = "spoChBox";
            this.spoChBox.Size = new System.Drawing.Size(193, 20);
            this.spoChBox.TabIndex = 0;
            this.spoChBox.Text = "Microsoft SharePoint Online";
            this.spoChBox.UseVisualStyleBackColor = true;
            // 
            // vmwareChBox
            // 
            this.vmwareChBox.AutoSize = true;
            this.vmwareChBox.Location = new System.Drawing.Point(9, 124);
            this.vmwareChBox.Name = "vmwareChBox";
            this.vmwareChBox.Size = new System.Drawing.Size(82, 20);
            this.vmwareChBox.TabIndex = 0;
            this.vmwareChBox.Text = "VMWare";
            this.vmwareChBox.UseVisualStyleBackColor = true;
            // 
            // teamsChBox
            // 
            this.teamsChBox.AutoSize = true;
            this.teamsChBox.Location = new System.Drawing.Point(9, 99);
            this.teamsChBox.Name = "teamsChBox";
            this.teamsChBox.Size = new System.Drawing.Size(129, 20);
            this.teamsChBox.TabIndex = 0;
            this.teamsChBox.Text = "Microsoft Teams";
            this.teamsChBox.UseVisualStyleBackColor = true;
            // 
            // exoChBox
            // 
            this.exoChBox.AutoSize = true;
            this.exoChBox.Location = new System.Drawing.Point(9, 73);
            this.exoChBox.Name = "exoChBox";
            this.exoChBox.Size = new System.Drawing.Size(187, 20);
            this.exoChBox.TabIndex = 0;
            this.exoChBox.Text = "Microsoft Exchange Online";
            this.exoChBox.UseVisualStyleBackColor = true;
            // 
            // microsoftBox
            // 
            this.microsoftBox.Controls.Add(this.sharePointOnPremChBox);
            this.microsoftBox.Controls.Add(this.exchOnPremChBox);
            this.microsoftBox.Location = new System.Drawing.Point(12, 235);
            this.microsoftBox.Name = "microsoftBox";
            this.microsoftBox.Size = new System.Drawing.Size(299, 76);
            this.microsoftBox.TabIndex = 4;
            this.microsoftBox.TabStop = false;
            this.microsoftBox.Text = "Microsoft collectors";
            // 
            // sharePointOnPremChBox
            // 
            this.sharePointOnPremChBox.AutoSize = true;
            this.sharePointOnPremChBox.Location = new System.Drawing.Point(9, 47);
            this.sharePointOnPremChBox.Name = "sharePointOnPremChBox";
            this.sharePointOnPremChBox.Size = new System.Drawing.Size(208, 20);
            this.sharePointOnPremChBox.TabIndex = 0;
            this.sharePointOnPremChBox.Text = "Microsoft SharePoint On-Prem";
            this.sharePointOnPremChBox.UseVisualStyleBackColor = true;
            // 
            // exchOnPremChBox
            // 
            this.exchOnPremChBox.AutoSize = true;
            this.exchOnPremChBox.Location = new System.Drawing.Point(9, 21);
            this.exchOnPremChBox.Name = "exchOnPremChBox";
            this.exchOnPremChBox.Size = new System.Drawing.Size(202, 20);
            this.exchOnPremChBox.TabIndex = 0;
            this.exchOnPremChBox.Text = "Microsoft Exchange On-Prem";
            this.exchOnPremChBox.UseVisualStyleBackColor = true;
            // 
            // microsoftServersBox
            // 
            this.microsoftServersBox.Controls.Add(this.ndcIntegrationChBox);
            this.microsoftServersBox.Controls.Add(this.fileServerChBox);
            this.microsoftServersBox.Controls.Add(this.uavrChBox);
            this.microsoftServersBox.Controls.Add(this.windowsServerChBox);
            this.microsoftServersBox.Location = new System.Drawing.Point(338, 102);
            this.microsoftServersBox.Name = "microsoftServersBox";
            this.microsoftServersBox.Size = new System.Drawing.Size(298, 127);
            this.microsoftServersBox.TabIndex = 2;
            this.microsoftServersBox.TabStop = false;
            this.microsoftServersBox.Text = "Microsoft Servers";
            this.microsoftServersBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ndcIntegrationChBox
            // 
            this.ndcIntegrationChBox.AutoSize = true;
            this.ndcIntegrationChBox.Location = new System.Drawing.Point(9, 99);
            this.ndcIntegrationChBox.Name = "ndcIntegrationChBox";
            this.ndcIntegrationChBox.Size = new System.Drawing.Size(205, 20);
            this.ndcIntegrationChBox.TabIndex = 0;
            this.ndcIntegrationChBox.Text = "Data Classification Integration";
            this.ndcIntegrationChBox.UseVisualStyleBackColor = true;
            // 
            // fileServerChBox
            // 
            this.fileServerChBox.AutoSize = true;
            this.fileServerChBox.Location = new System.Drawing.Point(9, 73);
            this.fileServerChBox.Name = "fileServerChBox";
            this.fileServerChBox.Size = new System.Drawing.Size(158, 20);
            this.fileServerChBox.TabIndex = 0;
            this.fileServerChBox.Text = "Microsoft File Servers";
            this.fileServerChBox.UseVisualStyleBackColor = true;
            // 
            // uavrChBox
            // 
            this.uavrChBox.AutoSize = true;
            this.uavrChBox.Location = new System.Drawing.Point(9, 47);
            this.uavrChBox.Name = "uavrChBox";
            this.uavrChBox.Size = new System.Drawing.Size(103, 20);
            this.uavrChBox.TabIndex = 0;
            this.uavrChBox.Text = "User Activity";
            this.uavrChBox.UseVisualStyleBackColor = true;
            // 
            // windowsServerChBox
            // 
            this.windowsServerChBox.AutoSize = true;
            this.windowsServerChBox.Location = new System.Drawing.Point(9, 21);
            this.windowsServerChBox.Name = "windowsServerChBox";
            this.windowsServerChBox.Size = new System.Drawing.Size(127, 20);
            this.windowsServerChBox.TabIndex = 0;
            this.windowsServerChBox.Text = "Windows Server";
            this.windowsServerChBox.UseVisualStyleBackColor = true;
            // 
            // sqlBox
            // 
            this.sqlBox.Controls.Add(this.oracleChBox);
            this.sqlBox.Controls.Add(this.microsoftSQLChBox);
            this.sqlBox.Location = new System.Drawing.Point(338, 235);
            this.sqlBox.Name = "sqlBox";
            this.sqlBox.Size = new System.Drawing.Size(298, 76);
            this.sqlBox.TabIndex = 2;
            this.sqlBox.TabStop = false;
            this.sqlBox.Text = "SQL Auditing";
            this.sqlBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // oracleChBox
            // 
            this.oracleChBox.AutoSize = true;
            this.oracleChBox.Location = new System.Drawing.Point(9, 47);
            this.oracleChBox.Name = "oracleChBox";
            this.oracleChBox.Size = new System.Drawing.Size(91, 20);
            this.oracleChBox.TabIndex = 0;
            this.oracleChBox.Text = "Oracle DB";
            this.oracleChBox.UseVisualStyleBackColor = true;
            // 
            // microsoftSQLChBox
            // 
            this.microsoftSQLChBox.AutoSize = true;
            this.microsoftSQLChBox.Location = new System.Drawing.Point(9, 21);
            this.microsoftSQLChBox.Name = "microsoftSQLChBox";
            this.microsoftSQLChBox.Size = new System.Drawing.Size(112, 20);
            this.microsoftSQLChBox.TabIndex = 0;
            this.microsoftSQLChBox.Text = "Microsoft SQL";
            this.microsoftSQLChBox.UseVisualStyleBackColor = true;
            // 
            // toolsBox
            // 
            this.toolsBox.Controls.Add(this.networkDevicesChBox);
            this.toolsBox.Controls.Add(this.syslogChBox);
            this.toolsBox.Controls.Add(this.penChBox);
            this.toolsBox.Controls.Add(this.elmChBox);
            this.toolsBox.Controls.Add(this.iutChBox);
            this.toolsBox.Location = new System.Drawing.Point(338, 317);
            this.toolsBox.Name = "toolsBox";
            this.toolsBox.Size = new System.Drawing.Size(298, 150);
            this.toolsBox.TabIndex = 2;
            this.toolsBox.TabStop = false;
            this.toolsBox.Text = "Netwrix Tools";
            this.toolsBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // networkDevicesChBox
            // 
            this.networkDevicesChBox.AutoSize = true;
            this.networkDevicesChBox.Location = new System.Drawing.Point(9, 124);
            this.networkDevicesChBox.Name = "networkDevicesChBox";
            this.networkDevicesChBox.Size = new System.Drawing.Size(131, 20);
            this.networkDevicesChBox.TabIndex = 0;
            this.networkDevicesChBox.Text = "Network Devices";
            this.networkDevicesChBox.UseVisualStyleBackColor = true;
            this.networkDevicesChBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // syslogChBox
            // 
            this.syslogChBox.AutoSize = true;
            this.syslogChBox.Location = new System.Drawing.Point(9, 99);
            this.syslogChBox.Name = "syslogChBox";
            this.syslogChBox.Size = new System.Drawing.Size(71, 20);
            this.syslogChBox.TabIndex = 0;
            this.syslogChBox.Text = "Syslog";
            this.syslogChBox.UseVisualStyleBackColor = true;
            // 
            // penChBox
            // 
            this.penChBox.AutoSize = true;
            this.penChBox.Location = new System.Drawing.Point(9, 73);
            this.penChBox.Name = "penChBox";
            this.penChBox.Size = new System.Drawing.Size(196, 20);
            this.penChBox.TabIndex = 0;
            this.penChBox.Text = "Password Expiration Notifier";
            this.penChBox.UseVisualStyleBackColor = true;
            // 
            // elmChBox
            // 
            this.elmChBox.AutoSize = true;
            this.elmChBox.Location = new System.Drawing.Point(9, 47);
            this.elmChBox.Name = "elmChBox";
            this.elmChBox.Size = new System.Drawing.Size(146, 20);
            this.elmChBox.TabIndex = 0;
            this.elmChBox.Text = "Event Log Manager";
            this.elmChBox.UseVisualStyleBackColor = true;
            // 
            // iutChBox
            // 
            this.iutChBox.AutoSize = true;
            this.iutChBox.Location = new System.Drawing.Point(9, 21);
            this.iutChBox.Name = "iutChBox";
            this.iutChBox.Size = new System.Drawing.Size(164, 20);
            this.iutChBox.TabIndex = 0;
            this.iutChBox.Text = "Inactive Users Tracker";
            this.iutChBox.UseVisualStyleBackColor = true;
            // 
            // systemLogs
            // 
            this.systemLogs.Controls.Add(this.configAdmConsole);
            this.systemLogs.Controls.Add(this.configChBox);
            this.systemLogs.Location = new System.Drawing.Point(659, 102);
            this.systemLogs.Name = "systemLogs";
            this.systemLogs.Size = new System.Drawing.Size(298, 77);
            this.systemLogs.TabIndex = 2;
            this.systemLogs.TabStop = false;
            this.systemLogs.Text = "Netwrix Health and Config";
            this.systemLogs.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // configAdmConsole
            // 
            this.configAdmConsole.AutoSize = true;
            this.configAdmConsole.Location = new System.Drawing.Point(6, 47);
            this.configAdmConsole.Name = "configAdmConsole";
            this.configAdmConsole.Size = new System.Drawing.Size(166, 20);
            this.configAdmConsole.TabIndex = 0;
            this.configAdmConsole.Text = "Administrative Console";
            this.configAdmConsole.UseVisualStyleBackColor = true;
            // 
            // configChBox
            // 
            this.configChBox.AutoSize = true;
            this.configChBox.Location = new System.Drawing.Point(6, 21);
            this.configChBox.Name = "configChBox";
            this.configChBox.Size = new System.Drawing.Size(130, 20);
            this.configChBox.TabIndex = 0;
            this.configChBox.Text = "Configuration.xml";
            this.configChBox.UseVisualStyleBackColor = true;
            // 
            // collectTrace
            // 
            this.collectTrace.Location = new System.Drawing.Point(659, 185);
            this.collectTrace.Name = "collectTrace";
            this.collectTrace.Size = new System.Drawing.Size(294, 69);
            this.collectTrace.TabIndex = 5;
            this.collectTrace.Text = "Collect Trace Logs";
            this.collectTrace.UseVisualStyleBackColor = true;
            // 
            // healthLogsButton
            // 
            this.healthLogsButton.Location = new System.Drawing.Point(659, 263);
            this.healthLogsButton.Name = "healthLogsButton";
            this.healthLogsButton.Size = new System.Drawing.Size(294, 69);
            this.healthLogsButton.TabIndex = 5;
            this.healthLogsButton.Text = "Collect Health Logs";
            this.healthLogsButton.UseVisualStyleBackColor = true;
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.statusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusTextBox.Location = new System.Drawing.Point(659, 338);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statusTextBox.Size = new System.Drawing.Size(294, 129);
            this.statusTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 491);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.healthLogsButton);
            this.Controls.Add(this.collectTrace);
            this.Controls.Add(this.microsoftBox);
            this.Controls.Add(this.cloudBox);
            this.Controls.Add(this.toolsBox);
            this.Controls.Add(this.sqlBox);
            this.Controls.Add(this.systemLogs);
            this.Controls.Add(this.microsoftServersBox);
            this.Controls.Add(this.adBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.adBox.ResumeLayout(false);
            this.adBox.PerformLayout();
            this.cloudBox.ResumeLayout(false);
            this.cloudBox.PerformLayout();
            this.microsoftBox.ResumeLayout(false);
            this.microsoftBox.PerformLayout();
            this.microsoftServersBox.ResumeLayout(false);
            this.microsoftServersBox.PerformLayout();
            this.sqlBox.ResumeLayout(false);
            this.sqlBox.PerformLayout();
            this.toolsBox.ResumeLayout(false);
            this.toolsBox.PerformLayout();
            this.systemLogs.ResumeLayout(false);
            this.systemLogs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox adBox;
        private System.Windows.Forms.GroupBox cloudBox;
        private System.Windows.Forms.GroupBox microsoftBox;
        private System.Windows.Forms.CheckBox activeDirectoryChBox;
        private System.Windows.Forms.CheckBox adfsChBox;
        private System.Windows.Forms.CheckBox groupPolicyChBox;
        private System.Windows.Forms.CheckBox logonActivityChBox;
        private System.Windows.Forms.CheckBox sharePointOnPremChBox;
        private System.Windows.Forms.CheckBox exchOnPremChBox;
        private System.Windows.Forms.CheckBox azureADChBox;
        private System.Windows.Forms.CheckBox spoChBox;
        private System.Windows.Forms.CheckBox teamsChBox;
        private System.Windows.Forms.CheckBox exoChBox;
        private System.Windows.Forms.GroupBox microsoftServersBox;
        private System.Windows.Forms.CheckBox ndcIntegrationChBox;
        private System.Windows.Forms.CheckBox fileServerChBox;
        private System.Windows.Forms.CheckBox uavrChBox;
        private System.Windows.Forms.CheckBox windowsServerChBox;
        private System.Windows.Forms.GroupBox sqlBox;
        private System.Windows.Forms.CheckBox oracleChBox;
        private System.Windows.Forms.CheckBox microsoftSQLChBox;
        private System.Windows.Forms.GroupBox toolsBox;
        private System.Windows.Forms.CheckBox elmChBox;
        private System.Windows.Forms.CheckBox iutChBox;
        private System.Windows.Forms.CheckBox syslogChBox;
        private System.Windows.Forms.CheckBox penChBox;
        private System.Windows.Forms.GroupBox systemLogs;
        private System.Windows.Forms.CheckBox configChBox;
        private System.Windows.Forms.CheckBox vmwareChBox;
        private System.Windows.Forms.CheckBox networkDevicesChBox;
        private System.Windows.Forms.Button collectTrace;
        private System.Windows.Forms.CheckBox configAdmConsole;
        private System.Windows.Forms.Button healthLogsButton;
        private System.Windows.Forms.TextBox statusTextBox;
    }
}

