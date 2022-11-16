using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.Shared
{
    public class FrameworkConfiguration
    {
        public static string FrameworkToMigrate;

        public static string FrameworkTypeRead()
        {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Movies Rental Project");

            string framework = (string)registryKey.GetValue("FrameworkType");

            return framework;
        }

        public static void ChangeFrameworkType(string framework)
        {
            RegistryKey smb = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Movies Rental Project");
            smb.SetValue("FrameworkType", framework, RegistryValueKind.String);
        }

        public static void RevertFrameworkToMigration()
        {
            if (FrameworkTypeRead() == "SQLServer")
                ChangeFrameworkType("EntityFramework");
            else
                ChangeFrameworkType("SQLServer");
        }
    }
}
