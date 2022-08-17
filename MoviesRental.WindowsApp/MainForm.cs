using Autofac;
using MovieRental.Application.ClientModule;
using MoviesRental.Infra.SQL.ClientModule;
using MoviesRental.WindowsApp.Features.AccountModule;
using MoviesRental.WindowsApp.Features.ClientModule;
using MoviesRental.WindowsApp.Features.EmployeeModule;
using MoviesRental.WindowsApp.Features.MovieModule;
using MoviesRental.WindowsApp.Features.RentModule;
using MoviesRental.WindowsApp.Shared;

namespace MoviesRental.WindowsApp
{
    public partial class MainForm : Form
    {
        public static MainForm instance;

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
        }

        #region CodeMethods

        private void CheckStatusRent_Tick(object sender, EventArgs e)
        {
            rentOperations = AutoFacBuilder.Container.Resolve<RentOperations>();

            rentOperations.EditStatusRegister();
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

            toolStripSeparator1.Visible = true;

            toolStripSeparator2.Visible = true;

            toolStripSeparator3.Visible = true;

            toolStripSeparator4.Visible = false;

            toolStripSeparator5.Visible = false;

            toolStripSeparator6.Visible = false;
        }

        public void RentsButtons()
        {
            RegisterSelectedText.Visible = true;

            AccountButton.Visible = false;

            AddButton.Visible = true;

            EditButton.Visible = true;

            DeleteButton.Visible = false;

            FilterButton.Visible = true;

            DevolutionButton.Visible = true;

            toolStripSeparator1.Visible = true;

            toolStripSeparator2.Visible = true;

            toolStripSeparator3.Visible = true;

            toolStripSeparator4.Visible = false;

            toolStripSeparator5.Visible = false;

            toolStripSeparator6.Visible = false;

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

            operations = AutoFacBuilder.Container.Resolve<ClientOperations>();

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

            operations = AutoFacBuilder.Container.Resolve<EmployeeOperations>();

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

            operations = AutoFacBuilder.Container.Resolve<MovieOperations>();

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

            rentOperations = AutoFacBuilder.Container.Resolve<RentOperations>();

            ConfigPanelRentRegisters(rentOperations);
        }

        private void AccessMenuItem_Click(object sender, EventArgs e)
        {
            PanelHeader.Visible = true;

            AccessButtons();

            MainPanel.Controls.Clear();
        }

        #endregion

        #region ButtonsClick

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

        #endregion

        private void DevolutionButton_Click(object sender, EventArgs e)
        {
            rentOperations.RegisterDevolution();
        }
    }
}