using MovieRental.Application.EmployeModule;
using MoviesRental.Domain.EmployeeModule;
using MoviesRental.Domain.MovieModule;
using MoviesRental.Domain.Shared;
using MoviesRental.Infra.SQL;
using MoviesRental.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int id = employeeTable.GetIdSelected();

            if (id == 0)
            {
                MessageBox.Show("Select a employee to delete", "Employee deleting",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Employee employeeSelected = appService.SelectEmployeeId(id);

            if (MessageBox.Show($"Do you have sure about to delete: [{employeeSelected.Name}] ?",
                "Employee deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (appService.DeleteEmployee(id))
                {
                    employeeTable.UpdateRegisters();
                    MainForm.instance.UpdateFooter($"Employee: [{employeeSelected.Name}] deleted with success");
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

            EmployeeForm employee = new EmployeeForm();
            employee.Employee = employeeSelected;
            employee.ShowDialog();
            if (employee.DialogResult == DialogResult.OK)
            {
                string result = appService.EditEmployee(id, employee.Employee);

                if (result == "Is_Valid")
                {
                    employeeTable.UpdateRegisters();
                    MainForm.instance.UpdateFooter($"Employee: [{employee.Employee.Name}] edited with success");
                }
                else
                {
                    MainForm.instance.UpdateFooter(result);
                }
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
            EmployeeForm employeeForm = new EmployeeForm();

            if (employeeForm.ShowDialog() == DialogResult.OK)
            {
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
        }

        public void MigrateRegister()
        {
            foreach (Employee employeeToMigrate in employeesToMigrate)
            {
                Employee? employeeToEdit = appService.SelectEmployeeByName(employeeToMigrate);

                employeeToMigrate.Id = 0;

                string? getResult = ValidateMigrate(employeeToMigrate);

                if (getResult == "InsertingWhileMigrate")
                    appService.InsertNewEmploye(employeeToMigrate);

                if (getResult == "EditingWhileMigrate" && employeeToEdit != null)
                    appService.EditEmployee(employeeToEdit.Id, employeeToMigrate);
            }
        }

        private string? ValidateMigrate(Employee employee)
        {
            List<Employee> allEmployees = appService.SelectAllEmployees();

            if (allEmployees.Count == 0)
                return "InsertingWhileMigrate";

            bool name = allEmployees.Exists(d => d.Name == employee.Name);
            bool email = allEmployees.Exists(d => d.Email == employee.Email);
            bool password = allEmployees.Exists(d => d.Password == employee.Password);
            bool accessKey = allEmployees.Exists(d => d.AccessKey == employee.AccessKey);

            if (!name && !email && !password && !accessKey)
                return "InsertingWhileMigrate";

            if (name || email || password || accessKey)
                return "EditingWhileMigrate";

            return null;
        }

        UserControl IRegister.GetTableFiltered(string filter)
        {
            throw new NotImplementedException();
        }
    }
}
