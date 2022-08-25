using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                RegisterKey(getKey);

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

        public void RegisterKey(string framework)
        {
            RegistryKey smb = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Movies Rental Project");
            smb.SetValue("FrameworkType", framework, RegistryValueKind.String);
        }
    }
}
