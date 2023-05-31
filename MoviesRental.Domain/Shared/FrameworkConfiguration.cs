using System.Configuration;

namespace MoviesRental.Domain.Shared
{
    public class FrameworkConfiguration
    {
        public static string FrameworkTypeRead()
        {
            return ConfigurationManager.AppSettings["FrameworkType"];
        }

        public static void ChangeFrameworkType(string framework)
        {
            try
            {
               Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                if (config.AppSettings.Settings.AllKeys.Contains("FrameworkType"))
                {
                    config.AppSettings.Settings["FrameworkType"].Value = framework;
                }
                else
                {
                    config.AppSettings.Settings.Add("FrameworkType", framework);
                }

                config.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");
            }
            catch
            { }
        }
    }
}
