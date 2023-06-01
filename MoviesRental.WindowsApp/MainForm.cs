using Autofac;
using MoviesRental.Domain.EmployeeModule;
using MoviesRental.Domain.RentModule;
using MoviesRental.Domain.Shared;
using MoviesRental.WindowsApp.Features.AccountModule;
using MoviesRental.WindowsApp.Features.ClientModule;
using MoviesRental.WindowsApp.Features.EmployeeModule;
using MoviesRental.WindowsApp.Features.MovieModule;
using MoviesRental.WindowsApp.Features.RentModule;
using MoviesRental.WindowsApp.Features.SettingsModule;
using MoviesRental.WindowsApp.Shared;

namespace MoviesRental.WindowsApp
{
    public partial class MainForm : Form
    {
        public static MainForm? instance;

        private IRegister operations;

        private IRegisterRent rentOperations;

        public string statusOperation { get; set; }

        public MainForm()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            instance = this;
            PanelHeader.Visible = false;
            RentsMenuItem.Enabled = false;
            RegistersMenuItem.Enabled = false;
            AccountButton.Text = "Enter with account";
            DashboardPanel.Visible = false;
        }

        #region CodeMethods

        public void ShowAccountDashboard()
        {
            DashboardPanel.Visible = true;

            Dashboard dashboard = new Dashboard();

            MainPanel.Controls.Add(DashboardPanel);

            DashboardPanel.Controls.Add(dashboard);
        }

        public void HideAccountDashboard()
        {
            DashboardPanel.Visible = false;
        }

        public List<Rent> DashboardRents()
        {
            rentOperations = new AutoFacBuilder().Container.Resolve<RentOperations>();

            return RentOperations.instance.DashboardRents();
        }

        public Employee GetEmployee(string emailText)
        {
            operations = new AutoFacBuilder().Container.Resolve<EmployeeOperations>();

            List<Employee> employeesList = EmployeeOperations.instance.GetAllEmployees();

            foreach (Employee employee in employeesList) 
            {
                if (employee.Email == emailText)
                    return EmployeeOperations.instance.GetEmployeeSelected(employee.Id);
            }

            return null;
        }

        public List<Rent> GetAllRents()
        {
            rentOperations = new AutoFacBuilder().Container.Resolve<RentOperations>();

            return RentOperations.instance.GetList();
        }

        public void ChangeAccountName()
        {
            if (CurrentAccount.EmployeeName != null)
                AccountButton.Text = CurrentAccount.EmployeeName;
            else
                AccountButton.Text = "Enter with account";
        }

        public void UpdateFooter(string message)
        {
            StatusText.Text = message;
        }

        public void ConfigPanelRegistersStatusSelected(string status)
        {
            UserControl? table = null;

            if (status == null)
                table = rentOperations.GetTable();

            if (status != null)
                table = rentOperations.GetTableFiltered(status);

            table.Dock = DockStyle.Fill;

            MainPanel.Controls.Clear();

            MainPanel.Controls.Add(table);
        }

        private void ConfigPanelRegisters(IRegister operations)
        {
            UserControl table = operations.GetTable();
            table.Dock = DockStyle.Fill;

            MainPanel.Controls.Clear();

            MainPanel.Controls.Add(table);
        }

        private void ConfigPanelRentRegisters(IRegisterRent operations)
        {
            UserControl table = operations.GetTable();
            table.Dock = DockStyle.Fill;

            MainPanel.Controls.Clear();

            MainPanel.Controls.Add(table);
        }

        public void ShowMenuStripOptions()
        {
            RentsMenuItem.Enabled = true;
            RegistersMenuItem.Enabled = true;
        }

        public void DontShowMenuStripOptions()
        {
            RentsMenuItem.Enabled = false;
            RegistersMenuItem.Enabled = false;
        }

        private void ConfigToolBox(IConfigurationToolBox configuration)
        {
            RegisterSelectedText.Text = configuration.KindRegister;

            AddButton.ToolTipText = configuration.GetToolTips().Add;
            EditButton.ToolTipText = configuration.GetToolTips().Edit;
            DeleteButton.ToolTipText = configuration.GetToolTips().Delete;
        }

        #endregion

        #region Buttons

        public void AccessButtons()
        {
            AccountButton.Visible = true;

            AddButton.Visible = false;

            EditButton.Visible = false;

            DeleteButton.Visible = false;

            FilterButton.Visible = false;

            DevolutionButton.Visible = false;

            toolStripSeparator1.Visible = false;

            toolStripSeparator2.Visible = false;

            toolStripSeparator3.Visible = false;

            toolStripSeparator4.Visible = false;

            toolStripSeparator5.Visible = false;

            toolStripSeparator6.Visible = false;

            RegisterSelectedText.Visible = false;

            toolStripSeparator7.Visible = false;

            RefreshButton.Visible = false;
        }

        public void RegistersButtons()
        {
            RegisterSelectedText.Visible = true;

            AccountButton.Visible = false;

            FilterButton.Visible = false;

            AddButton.Visible = true;

            EditButton.Visible = true;

            DeleteButton.Visible = true;

            DevolutionButton.Visible = false;

            AddButton.Enabled = true;

            EditButton.Enabled = true;

            DeleteButton.Enabled = true;

            RefreshButton.Visible = false;

            toolStripSeparator1.Visible = true;

            toolStripSeparator2.Visible = true;

            toolStripSeparator3.Visible = true;

            toolStripSeparator4.Visible = false;

            toolStripSeparator5.Visible = false;

            toolStripSeparator6.Visible = false;

            toolStripSeparator7.Visible = false;
        }

        public void RentsButtons()
        {
            RegisterSelectedText.Visible = true;

            AccountButton.Visible = false;

            AddButton.Visible = true;

            EditButton.Visible = true;

            DeleteButton.Visible = false;

            FilterButton.Visible = true;

            RefreshButton.Visible = true;

            DevolutionButton.Visible = true;

            toolStripSeparator1.Visible = true;

            toolStripSeparator2.Visible = true;

            toolStripSeparator3.Visible = true;

            toolStripSeparator4.Visible = false;

            toolStripSeparator5.Visible = false;

            toolStripSeparator6.Visible = false;

            toolStripSeparator7.Visible = true;

            EditButton.Visible = false;
        }

        #endregion

        #region MenuItemOptions

        public void ClientOption_Click(object sender, EventArgs e)
        {
            statusOperation = "Operation";

            RegistersButtons();

            PanelHeader.Visible = true;

            ClientConfigurationToolBox configuration = new ClientConfigurationToolBox();

            ConfigToolBox(configuration);

            UpdateFooter(configuration.KindRegister);

            operations = new AutoFacBuilder().Container.Resolve<ClientOperations>();

            ConfigPanelRegisters(operations);
        }

        public void EmployeeOption_Click(object sender, EventArgs e)
        {
            statusOperation = "Operation";

            RegistersButtons();

            PanelHeader.Visible = true;

            EmployeeConfigurationToolBox configuration = new EmployeeConfigurationToolBox();

            ConfigToolBox(configuration);

            UpdateFooter(configuration.KindRegister);

            operations = new AutoFacBuilder().Container.Resolve<EmployeeOperations>();

            ConfigPanelRegisters(operations);
        }

        private void MovieOption_Click(object sender, EventArgs e)
        {
            statusOperation = "Operation";

            RegistersButtons();

            PanelHeader.Visible = true;

            MovieConfigurationToolBox configuration = new MovieConfigurationToolBox();

            ConfigToolBox(configuration);

            UpdateFooter(configuration.KindRegister); 

            operations = new AutoFacBuilder().Container.Resolve<MovieOperations>();

            ConfigPanelRegisters(operations);
        }

        private void RentsMenuItem_Click(object sender, EventArgs e)
        {
            statusOperation = "";

            RentsButtons();

            MainPanel.Controls.Clear();

            PanelHeader.Visible = true;

            RentConfigurationToolBox configuration = new RentConfigurationToolBox();

            ConfigToolBox(configuration);

            UpdateFooter(configuration.KindRegister);

            rentOperations = new AutoFacBuilder().Container.Resolve<RentOperations>();

            ConfigPanelRentRegisters(rentOperations);
        }

        public void ChangeToAccessRegister()
        {
            MainPanel.Controls.Clear();

            PanelHeader.Visible = false;
        }

        private void AccessMenuItem_Click(object sender, EventArgs e)
        {
            PanelHeader.Visible = true;

            AccessButtons();

            LogoPictureBox.Visible = false;

            MainPanel.Controls.Clear();

            if (CurrentAccount.EmployeeName != null)
            {
                Dashboard dashboard = new Dashboard();

                MainPanel.Controls.Add(DashboardPanel);

                DashboardPanel.Controls.Add(dashboard);
            }
        }

        #endregion

        #region ButtonsClick

        private void FrameworkMenuItem_Click(object sender, EventArgs e)
        {
            FrameworkSettingsForm frameworkSettingsForm = new FrameworkSettingsForm();

            frameworkSettingsForm.ShowDialog();
        }

        private void DevolutionButton_Click(object sender, EventArgs e)
        {
            rentOperations.RegisterDevolution();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (statusOperation == "Operation")
                operations.InsertNewRegister();
            else
                rentOperations.InsertNewRegister();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            operations.EditRegister();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            operations.DeleteRegister();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();

            accountForm.ShowDialog();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilterRentForm filterRentForm = new FilterRentForm();

            filterRentForm.ShowDialog();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            rentOperations = new AutoFacBuilder().Container.Resolve<RentOperations>();

            rentOperations.EditStatusRegister();

            ConfigPanelRentRegisters(rentOperations);
        }

        #endregion
    }
}