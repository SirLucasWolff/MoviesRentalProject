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
    public partial class AccountForm : Form
    {
        NewAccessAccountScreen newScreen;

        CurrentAccountScreen currentScreen;

        public static AccountForm instance;

        public AccountForm()
        {
            newScreen = new NewAccessAccountScreen();
            currentScreen = new CurrentAccountScreen();

            InitializeComponent();
            ScreenStart();

            instance = this;
        }

        public void CloseForm()
        {
            this.Close();
        }

        public void ScreenStart()
        {
            if (CurrentAccount.EmployeeName == null)
            {
                ScreensPanel.Controls.Add(newScreen);
            }
            else
            {
                ScreensPanel.Controls.Add(currentScreen);
            }
        }
    }
}
