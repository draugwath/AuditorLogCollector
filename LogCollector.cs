using System;
using System.IO;
using System.Windows.Forms;

namespace AuditorLogCollector
{
    public static class LogCollector
    {
        public static void CollectLogs(CheckedListBox.CheckedItemCollection selectedModules, TextBox statusTextBox)
        {
            if (!CollectorsPaths.FetchWorkingFolderPath())
            {
                statusTextBox.Text = "Failed to fetch working folder path.";
                return;
            }

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string logsDestination = Path.Combine(desktopPath, "CollectedLogs");
            Directory.CreateDirectory(logsDestination);

            foreach (var module in selectedModules)
            {
                string moduleName = module.ToString();
                string[] logPaths = CollectorsPaths.GetPathsForModule(moduleName);

                if (logPaths != null)
                {
                    foreach (string logPath in logPaths)
                    {
                        string fullPath = Path.GetFullPath(logPath);
                        if (Directory.Exists(fullPath))
                        {
                            string destination = Path.Combine(logsDestination, moduleName);
                            Directory.CreateDirectory(destination);
                            CopyDirectory(fullPath, destination);
                        }
                    }
                }
            }

            statusTextBox.Text = "Log collection complete.";
        }

        private static void CopyDirectory(string sourceDir, string destinationDir)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDir);

            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory does not exist or could not be found: {sourceDir}");

            DirectoryInfo[] dirs = dir.GetDirectories();
            if (!Directory.Exists(destinationDir))
            {
                Directory.CreateDirectory(destinationDir);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(tempPath, false);
            }

            foreach (DirectoryInfo subdir in dirs)
            {
                string tempPath = Path.Combine(destinationDir, subdir.Name);
                CopyDirectory(subdir.FullName, tempPath);
            }
        }
    }
}
