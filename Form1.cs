using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Windows.Forms;

namespace AuditorLogCollector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.collectTrace.Click += new System.EventHandler(this.CollectButton_Click);
            this.healthLogsButton.Click += new EventHandler(this.HealthLogsButton_Click);
        }

        private void CollectButton_Click(object sender, EventArgs e)
        {
            Logger.Log("Collect button clicked.");
            statusTextBox.Text = "Starting log collection...";
            var selectedModules = new List<string>();

            // Check each checkbox and add the module name if checked
            if (activeDirectoryChBox.Checked)
                selectedModules.Add("Active Directory");
            if (adfsChBox.Checked)
                selectedModules.Add("AD-FS");
            if (groupPolicyChBox.Checked)
                selectedModules.Add("Group Policy");
            if (logonActivityChBox.Checked)
                selectedModules.Add("Logon Activity");
            if (azureADChBox.Checked)
                selectedModules.Add("Azure AD");
            if (spoChBox.Checked)
                selectedModules.Add("SharePoint Online");
            if (vmwareChBox.Checked)
                selectedModules.Add("VMWare");
            if (teamsChBox.Checked)
                selectedModules.Add("Microsoft Teams");
            if (exoChBox.Checked)
                selectedModules.Add("Exchange Online");
            if (sharePointOnPremChBox.Checked)
                selectedModules.Add("SharePoint On-Prem");
            if (exchOnPremChBox.Checked)
                selectedModules.Add("Exchange On-Prem");
            if (ndcIntegrationChBox.Checked)
                selectedModules.Add("NDC Provider");
            if (fileServerChBox.Checked)
                selectedModules.Add("File Servers");
            if (uavrChBox.Checked)
                selectedModules.Add("User Activity Video Recording");
            if (windowsServerChBox.Checked)
                selectedModules.Add("Windows Server");
            if (oracleChBox.Checked)
                selectedModules.Add("Oracle DB");
            if (microsoftSQLChBox.Checked)
                selectedModules.Add("Microsoft SQL");
            if (networkDevicesChBox.Checked)
                selectedModules.Add("Network Devices");
            if (syslogChBox.Checked)
                selectedModules.Add("Syslog");
            if (penChBox.Checked)
                selectedModules.Add("Password Expiration Notifier");
            if (elmChBox.Checked)
                selectedModules.Add("Event Log Manager");
            if (iutChBox.Checked)
                selectedModules.Add("Inactive User Tracker");
            if (configChBox.Checked)
                selectedModules.Add("Configuration.xml");
            if (configAdmConsole.Checked)
                selectedModules.Add("Administrative Console");

            // Now selectedModules contains all the selected module names
            // Call the log collection method with the selected modules
            if (CollectorsPaths.FetchWorkingFolderPath())
            {
                Logger.Log($"Working folder path: {CollectorsPaths.WorkingFolder}");
                LogCollector.CollectLogs(selectedModules, statusTextBox);
            }
            else
            {
                Logger.Log("Failed to fetch working folder path.");
                statusTextBox.Text = "Failed to fetch working folder path.";
            }
        }

        private void HealthLogsButton_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string logsDestination = Path.Combine(desktopPath, "Netwrix Auditor Logs");
            Directory.CreateDirectory(logsDestination); // This will create the directory if it doesn't exist

            string sourceLogPath = Path.Combine(Environment.ExpandEnvironmentVariables("%SystemRoot%"), @"System32\Winevt\Logs\Netwrix Auditor.evtx");
            string destinationLogPath = Path.Combine(logsDestination, "NetwrixAuditorSystemHealthLog.evtx");

            try
            {
                File.Copy(sourceLogPath, destinationLogPath, true); // true to overwrite if it already exists
                MessageBox.Show("Health log exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to export health log: {ex.Message} Make sure you're running the application as an Administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
