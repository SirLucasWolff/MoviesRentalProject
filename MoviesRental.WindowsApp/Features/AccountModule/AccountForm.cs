using MoviesRental.WindowsApp.Shared;

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
                ScreensPanel.Controls.Add(newScreen);
            else
                ScreensPanel.Controls.Add(currentScreen);

        }
    }
}
