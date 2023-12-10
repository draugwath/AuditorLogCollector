using System;
using System.Windows.Forms;

namespace AuditorLogCollector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.collectButton1.Click += new System.EventHandler(this.CollectButton_Click);
        }

        private void CollectButton_Click(object sender, EventArgs e)
        {
            statusTextBox.Text = "Starting log collection...";
            // Assuming LogCollector.CollectLogs is a method you have defined elsewhere
            // and modulesCheckListBox and statusTextBox are controls on your form
            LogCollector.CollectLogs(modulesCheckListBox.CheckedItems, statusTextBox);
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
