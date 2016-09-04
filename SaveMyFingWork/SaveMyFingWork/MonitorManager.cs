using SaveMyFIngWork;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Xml;

namespace SaveMyFingWork
{
    public class MonitorManager
    {
        public List<MonitoredDirectory> MonitoredDirectories;
        public bool runMonitoringTask = false;
        System.Timers.Timer _timer;

        public MonitorManager()
        {
            MonitoredDirectories = new List<MonitoredDirectory>();

            _timer = new System.Timers.Timer(10000); 
            _timer.Elapsed += (sender, e) => MyElapsedMethod(sender, e, MonitoredDirectories, _timer);
            _timer.Enabled = false;
        }

        public void LoadConfig()
        {
            if (!File.Exists("config.xml"))
            {
                SaveConfig();
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("config.xml");

            XmlNodeList nodes = xmlDoc.SelectNodes("//monitor");
            foreach(XmlNode node in nodes)
            {
                AddNewMonitoredDirectory(node.Attributes["directorypath"].Value, node.Attributes["backuptopath"].Value);
            }
        }


        public void SaveConfig()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("config");

            foreach (MonitoredDirectory directory in MonitoredDirectories)
            {
                XmlElement newElement = xmlDoc.CreateElement("monitor");
                newElement.SetAttribute("directorypath", directory.DirectoryPath);
                newElement.SetAttribute("backuptopath", directory.BackupToPath);
                root.AppendChild(newElement);
            }

            xmlDoc.AppendChild(root);
            xmlDoc.Save("config.xml");
        }


        internal void DeleteAllBackups()
        {
            foreach(MonitoredDirectory directory in MonitoredDirectories)
            {
                string[] filePaths = Directory.GetFiles(directory.DirectoryPath, "*.*", SearchOption.AllDirectories);

                foreach(string filePath in filePaths)
                {
                    try
                    {
                        File.Delete(filePath);
                    }
                    catch (Exception)
                    {
                        //IGNORE - FILE MAY BE LOCKED
                    }
                }
            }
        }

        public void AddNewMonitoredDirectory(string directorypath, string backuptopath)
        {
            IList<MonitoredDirectory> match = MonitoredDirectories.Where(p => p.DirectoryPath == directorypath).ToList();
            if (match != null && match.Count == 0)
            {
                MonitoredDirectories.Add(new MonitoredDirectory(directorypath, backuptopath));
                SaveConfig();
            }
        }         

        public void DeleteMonitoredDirectory(string directorypath)
        {
            IList<MonitoredDirectory> match = MonitoredDirectories.Where(p => p.DirectoryPath == directorypath).ToList();
            if (match != null && match.Count == 1)
            {
                MonitoredDirectories.Remove(match[0]);
                SaveConfig();
            }
        }


        internal void ToggleMonitor()
        {
            if (runMonitoringTask)
            {
                runMonitoringTask = false;
                _timer.Enabled = false;
            }
            else
            {
                runMonitoringTask = true;
                _timer.Enabled = true;
            }            
        }


        static void MyElapsedMethod(object sender, ElapsedEventArgs e, List<MonitoredDirectory> MonitoredDirectories, System.Timers.Timer _timer)
        {
            foreach (MonitoredDirectory monitoredDirectory in MonitoredDirectories)
            {
                monitoredDirectory.RefreshFileExistence();
                monitoredDirectory.CheckFilesForChanges();
            }
        }


        
    }
}
