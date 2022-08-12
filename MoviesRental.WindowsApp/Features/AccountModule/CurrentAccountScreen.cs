using MoviesRental.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesRental.WindowsApp.Features.AccountModule
{
    public partial class CurrentAccountScreen : UserControl
    {
        public CurrentAccountScreen()
        {
            InitializeComponent();
            CurrentAccountName.Text = CurrentAccount.EmployeeName;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentAccount.EmployeeName = null;

            AccountForm.instance.ScreenStart();

            AccountForm.instance.CloseForm();

            MainForm.instance.DontShowMenuStripOptions();
        }
    }
}
