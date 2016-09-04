using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveMyFIngWork
{
    public class MonitoredDirectory
    {
        public string DirectoryPath { get; set; }
        public string BackupToPath { get; set; }
        public Dictionary<string, DateTime> FilePathAndTimeStampDefinitions;
        bool _Enabled = false;

        public MonitoredDirectory(string directorypath, string backupto)
        {
            FilePathAndTimeStampDefinitions = new Dictionary<string, DateTime>();

            DirectoryPath = directorypath;
            BackupToPath = backupto;

            if (!Directory.Exists(BackupToPath))
            {
                Directory.CreateDirectory(BackupToPath);
            }

            if (Directory.Exists(DirectoryPath) && Directory.Exists(BackupToPath))
            {
                _Enabled = true;
                RefreshFileExistence();
            }
        }

        public void RefreshFileExistence()
        {
            if (_Enabled)
            {
                List<String> _tempFilePaths = System.IO.Directory.GetFiles(DirectoryPath, "*.*", System.IO.SearchOption.AllDirectories).ToList();

                foreach (string tempPath in _tempFilePaths)
                {
                    if (!FilePathAndTimeStampDefinitions.Keys.Contains(tempPath))
                    {
                        FilePathAndTimeStampDefinitions.Add(tempPath, DateTime.MinValue);
                    }
                }
            }
        }

        public void CheckFilesForChanges()
        {
            if (_Enabled)
            {
                for(int i = 0; i < FilePathAndTimeStampDefinitions.Count; i++)
                {
                    string filePath = FilePathAndTimeStampDefinitions.Keys.ElementAt(i);

                    if (File.Exists(filePath))
                    {
                        DateTime lastModifiedDateTime = File.GetLastWriteTime(filePath);
                        if (lastModifiedDateTime != FilePathAndTimeStampDefinitions[filePath])
                        {
                            BackupFile(filePath, lastModifiedDateTime);
                        }
                    }
                }
            }
        }


        void BackupFile(string filePath, DateTime lastModifiedDateTime)
       {
            if (_Enabled)
            {
                string fileTimeStamp = lastModifiedDateTime.ToString("yyyy-MM-dd_HH-mm-ss_", CultureInfo.InvariantCulture);

                string newPath = Path.GetDirectoryName(filePath);
                newPath = newPath.Replace(DirectoryPath, BackupToPath);

                string newFileName = newPath + @"\" + fileTimeStamp + Path.GetFileName(filePath);

                try
                {
                    File.Copy(filePath, newFileName);
                    FilePathAndTimeStampDefinitions[filePath] = lastModifiedDateTime;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred during Backup", string.Format("An error occurred backing up '{0}'{1}{2}", filePath, Environment.NewLine, ex.Message));
                }
                
            }
        }

    }
}
