using MovieRental.Application.EmployeModule;
using MoviesRental.Domain.EmployeeModule;
using MoviesRental.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.WindowsApp.Features.EmployeeModule
{
    public class EmployeeOperations : IRegister
    {
        private EmployeAppService appService = null;

        private EmployeeTable employeeTable = null;

        public EmployeeOperations (EmployeAppService appService)
        {
            this.appService = appService;
            employeeTable = new EmployeeTable(appService);
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

        UserControl IRegister.GetTableFiltered(string filter)
        {
            throw new NotImplementedException();
        }
    }
}
