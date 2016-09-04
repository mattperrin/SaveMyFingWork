using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveMyFIngWork
{
    public partial class AddDirectory : Form
    {
        public string DirectoryPath {get; set; }
        public string BackupToPath { get; set; }
        public DialogResult Result { get; set; }

        public AddDirectory()
        {
            InitializeComponent();
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            DirectoryPath = "";
            BackupToPath = "";
            Result = DialogResult.Cancel;
            this.Close();
        }

        private void btnOkAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DirectoryPath))
            {
                MessageBox.Show("Missing Directory Path");
                return;
            }
            else if (string.IsNullOrEmpty(BackupToPath))
            {
                MessageBox.Show("Missing BackupTo Path");
                return;
            }
            else if (BackupToPath.Contains(DirectoryPath))
            {
                MessageBox.Show("Error - Back Up To Directory must not be within monitored directory path.");
                return;
            }


            Result = DialogResult.OK;
            this.Close();
        }

        private void btn_DirectoryToMonitorSelectDialog_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                DirectoryPath = folderBrowserDialog1.SelectedPath;
                txt_DirectoryToMonitor.Text = DirectoryPath;
            }
        }

        private void btn_BackupToSelectDialog_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackupToPath = folderBrowserDialog1.SelectedPath;
                txt_BackupToDirectory.Text = BackupToPath;
            }
        }
    }
}
