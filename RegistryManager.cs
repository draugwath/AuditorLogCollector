using Microsoft.Win32;
using System;

namespace AuditorLogCollector
{
    public static class RegistryManager
    {
        public static string GetWorkingFolderPath()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Netwrix Auditor\DataPathOverride"))
                {
                    if (key != null)
                    {
                        object value = key.GetValue("DataPathOverride");
                        return value != null ? value.ToString() : "DataPathOverride not set in registry.";
                    }
                    return "Registry key not found.";
                }
            }
            catch (Exception ex)
            {
                return "Error accessing registry: " + ex.Message;
            }
        }
    }
}
