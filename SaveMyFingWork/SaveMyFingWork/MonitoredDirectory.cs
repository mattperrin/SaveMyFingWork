using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveMyFIngWork
{
    public class MonitoredDirectory
    {
        public string DirectoryPath { get; set; }
        public string BackupToPath { get; set; }
        public Dictionary<string, DateTime> FilePathAndTimeStampDefinitions;

        public MonitoredDirectory(string directorypath, string backupto)
        {
            DirectoryPath = directorypath;
            BackupToPath = backupto;
        }

        public void RefreshFileExistance()
        {
            List<String> _tempFilePaths = System.IO.Directory.GetFiles(DirectoryPath, "*.*", System.IO.SearchOption.AllDirectories).ToList();

            foreach(string tempPath in _tempFilePaths)
            {
                if (!FilePathAndTimeStampDefinitions.Keys.Contains(tempPath))
                {
                    FilePathAndTimeStampDefinitions.Add(tempPath, DateTime.MinValue);
                    BackupFile(tempPath);
                }
            }
        }

        public void CheckFilesForChanges()
        {
            foreach(string filePath in FilePathAndTimeStampDefinitions.Keys)
            {
                DateTime modifiedDateTime = File.GetLastWriteTime(filePath);
                if (modifiedDateTime != FilePathAndTimeStampDefinitions[filePath])
                {
                    BackupFile(filePath);
                }                
            }
        }


        void BackupFile(string filePath)
        {
            DateTime rightNow = DateTime.Now;

            string fileTimeStamp = rightNow.ToString("yyyy-MM-dd-HH-mm-ss-fff", CultureInfo.InvariantCulture);

            string newPath = Path.GetFullPath(filePath);
            newPath = newPath.Replace(DirectoryPath, BackupToPath);

            string newFileName = newPath + @"\" + fileTimeStamp + Path.GetFileName(filePath);

            File.Copy(filePath, newPath);
            FilePathAndTimeStampDefinitions[filePath] = rightNow;
        }

    }
}
