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

        public Form1()
        {
            InitializeComponent();
            _MonitorManager = new MonitorManager();
            _MonitorManager.LoadConfig();
            _MonitorManager.AddNewDirectory("TEST", "TEST2");
            _MonitorManager.SaveConfig();
        }


        private void btn_AddDirectoryToMonitor_Click(object sender, EventArgs e)
        {

        }

        private void btn_ToggleMonitor_Click(object sender, EventArgs e)
        {

        }

        private void btn_DeleteAllBackups_Click(object sender, EventArgs e)
        {

        }
    }
}
