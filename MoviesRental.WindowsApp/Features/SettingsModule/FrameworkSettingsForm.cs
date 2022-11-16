using MoviesRental.Domain.Shared;

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
            if (getKey != null)
            {
                MainForm.instance.MigrationDatabase(getKey);

                Application.Restart();
            }
        }

        private void SQLServerRB_MouseClick(object sender, MouseEventArgs e)
        {
            getKey = "SQLServer";
        }

        private void EntityFrameworkRB_MouseClick(object sender, MouseEventArgs e)
        {
            getKey = "EntityFramework";
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
