using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AuditorLogCollector
{
    public static class CollectorsPaths
    {
        private static readonly Dictionary<string, string[]> paths = new Dictionary<string, string[]>
        {
            { "Active Directory", new [] { @"%Working_Folder%\Logs\ActiveDirectory" } },
            { "Azure AD", new [] { @"%Working_Folder%\Logs\Azure AD" } },
            { "Event Log Manager", new [] { @"%Working_Folder%\Logs\Event Log Management" } },
            { "Exchange On-Prem", new [] { @"%Working_Folder%\Logs\Exchange" } },
            { "Exchange Online", new [] { @"%Working_Folder%\Logs\Exchange Online" } },
            { "AD-FS", new [] { @"%Working_Folder%\Logs\DataCollectionCore\NwAdfsSvc" } },
            { "Group Policy", new [] { @"%Working_Folder%\Logs\GroupPolicy" } },
            { "Inactive User Tracker", new [] { @"%Working_Folder%\Logs\Inactive Users Tracker" } },
            { "Logon Activity", new [] { @"%Working_Folder%\Logs\DataCollectionCore\NwNLASvc" } },
            { "MS Teams", new [] { @"%Working_Folder%\Logs\MS Teams Auditing", @"%Working_Folder%\Logs\Azure AD", @"%Working_Folder%\Logs\SharePoint Online Auditing\Teams" } },
            { "Network Devices", new [] { @"%Working_Folder%\Logs\DataCollectionCore\NwNetworkDeviceSvc", @"%Working_Folder%\Logs\DataCollectionCore\NwSyslogCollectionSvc" } },
            { "NDC Provider", new [] { @"%Working_Folder%\Logs\Data Discovery and Classification" } },
            { "Nomba", new [] { @"%Working_Folder%\Logs\Nomba" } },
            { "Oracle DB", new [] { @"%Working_Folder%\Logs\DataCollectionCore\NwOracleSvc" } },
            { "Password Expiration Notifier", new [] { @"%Working_Folder%\Logs\Password Expiration Notifier" } },
            { "SharePoint On-Prem", new [] { @"%Working_Folder%\Logs\SharePoint Auditing" } },
            { "SharePoint Online", new [] { @"%Working_Folder%\Logs\SharePoint Online Auditing" } },
            { "SQL", new [] { @"%Working_Folder%\Logs\SQL Server Auditing" } },
            { "User Activity Video Recording", new [] { @"%Working_Folder%\Logs\User Activity Video Recording" } },
            { "VMWare", new [] { @"%Working_Folder%\Logs\VMware Auditing\Tracing" } },
            { "File Servers", new [] { @"%Working_Folder%\Logs\DataCollectionCore\NwFileStorageSvc" } },
            { "Windows Server", new [] { @"%Working_Folder%\Logs\Windows Server Auditing", @"%Working_Folder%\Logs\AuditCore\WSA" } },
            { "Configuration.xml", new [] { @"%Working_Folder%\AuditCore\ConfigServer"} },
            { "Administrative Console", new [] { @"%Working_Folder%\Logs\Administrative Console"} }
        };

        public static string WorkingFolder { get; private set; }

        public static bool FetchWorkingFolderPath()
        {
            string path = RegistryManager.GetWorkingFolderPath();
            if (!string.IsNullOrEmpty(path))
            {
                WorkingFolder = path;
                return true;
            }

            Debug.WriteLine("Failed to fetch working folder path");
            return false;
        }

        public static string[] GetPathsForModule(string moduleName)
        {
            if (paths.TryGetValue(moduleName, out var relativePaths))
            {
                return relativePaths.Select(p => p.Replace("%Working_Folder%", WorkingFolder)).ToArray();
            }
            return null;
        }

        public static IEnumerable<string> ModuleNames => paths.Keys;
    }
}
