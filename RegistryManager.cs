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
                        // Accessing the default (unnamed) value
                        object value = key.GetValue(null); // or key.GetValue("")
                        return value != null ? value.ToString() : "Default value not set in registry.";
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
