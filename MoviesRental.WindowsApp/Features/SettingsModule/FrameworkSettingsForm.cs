using MoviesRental.Domain.Shared;
using System.Configuration;

namespace MoviesRental.WindowsApp.Features.SettingsModule
{
    public partial class FrameworkSettingsForm : Form
    {
        public string? getKey = null;

        public FrameworkSettingsForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void SQLServerRB_MouseClick(object sender, MouseEventArgs e)
        {
            getKey = "SQLServer";

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["FrameworkType"].Value = getKey;

            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
        }

        private void EntityFrameworkRB_MouseClick(object sender, MouseEventArgs e)
        {
            getKey = "EntityFramework";

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["FrameworkType"].Value = getKey;

            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
        }

        private void FrameworkSettingsForm_Load(object sender, EventArgs e)
        {
            if (FrameworkConfiguration.FrameworkTypeRead() == "SQLServer")
                SQLServerRB.Checked = true;
            else
                EntityFrameworkRB.Checked = true;
        }
    }
}
