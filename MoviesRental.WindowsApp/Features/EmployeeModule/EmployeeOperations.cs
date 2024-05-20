using MovieRental.Application.EmployeModule;
using MoviesRental.Domain.EmployeeModule;
using MoviesRental.WindowsApp.Shared;

namespace MoviesRental.WindowsApp.Features.EmployeeModule
{
    public class EmployeeOperations : IRegister
    {
        private EmployeAppService appService;

        private EmployeeTable employeeTable;

        public static EmployeeOperations instance;

        public static List<Employee> employeesToMigrate = new List<Employee>();

        public EmployeeOperations(EmployeAppService appService)
        {
            instance = this;
            this.appService = appService;
            employeeTable = new EmployeeTable(appService);
        }

        public void GetList()
        {
            List<Employee> employees = appService.SelectAllEmployees();

            employeesToMigrate.AddRange(employees);
        }

        public void DeleteRegister()
        {
            List<Employee> employeesList = appService.SelectAllEmployees();

            Employee employeeSelected = new Employee();

            foreach (Employee employee in employeesList)
            {
                if (employee.Name == CurrentAccount.EmployeeName)
                    employeeSelected = appService.SelectEmployeeId(employee.Id);
            }

            if (MessageBox.Show($"Do you have sure about to delete: [{employeeSelected.Name}] ? You will be disconected!",
                "Employee deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (appService.DeleteEmployee(employeeSelected.Id))
                {
                    employeeTable.UpdateRegisters();

                    MainForm.instance.UpdateFooter($"Employee: [{employeeSelected.Name}] deleted with success");

                    CurrentAccount.EmployeeName = null;

                    MainForm.instance.DontShowMenuStripOptions();

                    MainForm.instance.ChangeAccountName();

                    MainForm.instance.ChangeToAccessRegister();
                }
                else
                {
                    MainForm.instance.UpdateFooter($"It wasn't possible to delete the employee {employeeSelected.Name}");
                }
            }
        }

        public void EditRegister()
        {
            int id = employeeTable.GetIdSelected();

            if (id == 0)
            {
                MessageBox.Show("Select a employee to edit", "Employee editing",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Employee employeeSelected = appService.SelectEmployeeId(id);

            if (employeeSelected.Name != CurrentAccount.EmployeeName)
            {
                MessageBox.Show("You can't edit another employee", "Employee editing",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            EmployeeForm employee = new EmployeeForm(false);

            employee.Employee = employeeSelected;

            bool datasRequiredIsNull;

            do
            {
                employee.ShowDialog();

                if (employee.DialogResult != DialogResult.OK) return;

                datasRequiredIsNull = String.IsNullOrEmpty(employee.Employee.Name)
                                     | String.IsNullOrEmpty(employee.Employee.Email)
                                     | String.IsNullOrEmpty(employee.Employee.Password);

                if (datasRequiredIsNull)
                {
                    MessageBox.Show("There are empty informations", "Employee form",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            while (datasRequiredIsNull);

            string result = appService.EditEmployee(id, employee.Employee);

            if (result == "Is_Valid")
            {
                CurrentAccount.EmployeeName = employee.Employee.Name;
                employeeTable.UpdateRegisters();
                MainForm.instance.UpdateFooter($"Employee: [{employee.Employee.Name}] edited with success");
                MainForm.instance.ChangeAccountName();
            }
            else
            {
                MainForm.instance.UpdateFooter(result);
            }

        }

        public UserControl GetTable()
        {
            employeeTable.UpdateRegisters();

            return employeeTable;
        }

        public UserControl GetTableFiltered()
        {
            throw new NotImplementedException();
        }

        public void InsertNewRegister()
        {
            EmployeeForm employeeForm = new EmployeeForm(true);

            bool datasRequiredIsNull;

            do
            {
                employeeForm.ShowDialog();

                if (employeeForm.DialogResult != DialogResult.OK) return;

                datasRequiredIsNull = String.IsNullOrEmpty(employeeForm.Employee.Name)
                                     | String.IsNullOrEmpty(employeeForm.Employee.Email)
                                     | String.IsNullOrEmpty(employeeForm.Employee.Password);

                if (datasRequiredIsNull)
                {
                    MessageBox.Show("There are empty informations", "Employee form",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            while (datasRequiredIsNull);

            string result = appService.InsertNewEmploye(employeeForm.Employee);

            if (result == "Is_Valid")
            {
                employeeTable.UpdateRegisters();
                MainForm.instance.UpdateFooter($"Employee {employeeForm.Employee.Name} inserted with success");
            }
            else
            {
                MainForm.instance.UpdateFooter(result);
            }
        }

        UserControl IRegister.GetTableFiltered(string filter)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeSelected(int id)
        {
            Employee employee = appService.SelectEmployeeId(id);

            return employee;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employee = appService.SelectAllEmployees();

            return employee;
        }
    }
}
