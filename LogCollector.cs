using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AuditorLogCollector
{
    public static class LogCollector
    {
        public static void CollectLogs(List<string> selectedModules, TextBox statusTextBox)
        {
            if (!CollectorsPaths.FetchWorkingFolderPath())
            {
                statusTextBox.Text = "Failed to fetch working folder path.";
                return;
            }

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string logsDestination = Path.Combine(desktopPath, "Netwrix Auditor Logs");
            Directory.CreateDirectory(logsDestination);

            foreach (var module in selectedModules)
            {
                Logger.Log($"Processing module: {module}");
                string[] logPaths = CollectorsPaths.GetPathsForModule(module);

                if (logPaths != null)
                {
                    foreach (string logPath in logPaths)
                    {
                        string fullPath = Path.GetFullPath(logPath);
                        if (Directory.Exists(fullPath))
                        {
                            // Create a unique destination for each log path
                            string destinationSubDir = Path.Combine(Path.Combine(logsDestination, module), Path.GetFileName(fullPath));
                            Directory.CreateDirectory(destinationSubDir);
                            CopyDirectory(fullPath, destinationSubDir);
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
            else
            {
                ClearDirectory(destinationDir);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(tempPath, true); // true to overwrite existing files
            }

            foreach (DirectoryInfo subdir in dirs)
            {
                string tempPath = Path.Combine(destinationDir, subdir.Name);
                CopyDirectory(subdir.FullName, tempPath);
            }
        }

        private static void ClearDirectory(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);

            foreach (FileInfo file in dir.GetFiles())
            {
                file.Delete();
            }

            foreach (DirectoryInfo subdir in dir.GetDirectories())
            {
                subdir.Delete(true);
            }
        }
    }
}
