using SaveMyFIngWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SaveMyFingWork
{
    public class MonitorManager
    {
        public List<MonitoredDirectory> MonitoredDirectories;

        public MonitorManager()
        {
            MonitoredDirectories = new List<MonitoredDirectory>();
        }

        public void LoadConfig()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("config.xml");

            XmlNodeList nodes = xmlDoc.SelectNodes("//monitor");
            foreach(XmlNode node in nodes)
            {
                AddNewDirectory(node.Attributes["directorypath"].Value, node.Attributes["backuptopath"].Value);
            }
        }

        public void SaveConfig()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode elem = xmlDoc.CreateNode("element", "config","");
            xmlDoc.AppendChild(elem);

            foreach (MonitoredDirectory directory in MonitoredDirectories)
            {
                XmlNode newElem = xmlDoc.CreateNode("element", "pages", "");
                newElem.Attributes["directorypath"].Value = directory.DirectoryPath;
                newElem.Attributes["backuptopath"].Value = directory.BackupToPath;
                elem.AppendChild(newElem);
            }

            xmlDoc.Save("config2.xml");

            //XmlElement root = doc.DocumentElement;
            //elem.AppendChild(newElem);
        }

        public void AddNewDirectory(string directorypath, string backuptopath)
        {
            //TODO: add in a collision check
            MonitoredDirectories.Add(new MonitoredDirectory(directorypath, backuptopath));
        }         



    }
}
