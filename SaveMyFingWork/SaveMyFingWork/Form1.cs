using SaveMyFIngWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveMyFingWork
{
    public partial class Form1 : Form
    {
        MonitorManager _MonitorManager;
        List<Button> _RegisteredButtons;
        List<TextBox> _RegisteredTextBoxes;

        public Form1()
        {
            InitializeComponent();
            _RegisteredButtons = new List<Button>();
            _RegisteredTextBoxes = new List<TextBox>();

            _MonitorManager = new MonitorManager();
            _MonitorManager.LoadConfig();
            RefreshUI();
        }


        private void btn_AddDirectoryToMonitor_Click(object sender, EventArgs e)
        {
            AddDirectory addDirectoryForm = new AddDirectory();
            addDirectoryForm.ShowDialog();

            if (addDirectoryForm.Result == DialogResult.OK)
            {
                _MonitorManager.AddNewMonitoredDirectory(addDirectoryForm.DirectoryPath, addDirectoryForm.BackupToPath);
                RefreshUI();
            }
        }

        private void btn_ToggleMonitor_Click(object sender, EventArgs e)
        {
            _MonitorManager.ToggleMonitor();
            
            if (_MonitorManager.runMonitoringTask)
            {
                btn_ToggleMonitor.Text = "- Stop Monitoring -";
                btn_ToggleMonitor.BackColor = Color.Yellow;
            }
            else
            {
                btn_ToggleMonitor.Text = "Start Monitoring";
                btn_ToggleMonitor.BackColor = SystemColors.Control;
            }
        }

        private void btn_DeleteAllBackups_Click(object sender, EventArgs e)
        {
            _MonitorManager.DeleteAllBackups();
        }

        private void RefreshUI()
        {
            foreach(Button btn in _RegisteredButtons)
            {
                btn.Dispose();
            }

            foreach (TextBox txt in _RegisteredTextBoxes)
            {
                txt.Dispose();
            }

            int defaultWidth = 260;
            int startingX = 10;
            int startingY = 80;


            //HEADINGS
            TextBox directoryHeading = new TextBox();
            directoryHeading.Text = "Monitored Directory";
            directoryHeading.Width = defaultWidth;
            directoryHeading.Location = new Point(startingX, startingY);
            directoryHeading.Enabled = false;
            _RegisteredTextBoxes.Add(directoryHeading);
            this.Controls.Add(directoryHeading);

            TextBox backupToHeading = new TextBox();
            backupToHeading.Text = "Backed Up To";
            backupToHeading.Width = defaultWidth;
            backupToHeading.Location = new Point(startingX + defaultWidth, startingY);
            backupToHeading.Enabled = false;
            _RegisteredTextBoxes.Add(backupToHeading);
            this.Controls.Add(backupToHeading);
            startingY += 20;


            foreach (MonitoredDirectory directory in _MonitorManager.MonitoredDirectories)
            {
                TextBox directoryTxtBox = new TextBox();
                directoryTxtBox.Text = directory.DirectoryPath;
                directoryTxtBox.Width = defaultWidth;
                directoryTxtBox.Location = new Point(startingX, startingY);
                _RegisteredTextBoxes.Add(directoryTxtBox);
                this.Controls.Add(directoryTxtBox);

                TextBox backupToTxtBox = new TextBox();
                backupToTxtBox.Text = directory.BackupToPath;
                backupToTxtBox.Width = defaultWidth;
                backupToTxtBox.Location = new Point(startingX + defaultWidth, startingY);
                _RegisteredTextBoxes.Add(backupToTxtBox);
                this.Controls.Add(backupToTxtBox);

                Button deleteButton = new Button();
                deleteButton.Text = "Delete";
                deleteButton.Name = directory.DirectoryPath;
                deleteButton.Width = 100;
                deleteButton.Location = new Point(startingX + defaultWidth + defaultWidth + 10, startingY);
                deleteButton.Click += new EventHandler(DeleteMonitoredDirectory);

                _RegisteredButtons.Add(deleteButton);
                this.Controls.Add(deleteButton);

                startingY += 20;
            }
        }

        private void DeleteMonitoredDirectory(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _MonitorManager.DeleteMonitoredDirectory(btn.Name);
            RefreshUI();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
