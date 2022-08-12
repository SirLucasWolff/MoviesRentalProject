using MoviesRental.WindowsApp.Shared;
using MovieRental.Application.EmployeModule;
using MoviesRental.Domain.EmployeeModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesRental.WindowsApp.Features.EmployeeModule
{
    public partial class EmployeeTable : UserControl
    {
        private readonly EmployeAppService employeeAppService;
        public EmployeeTable(EmployeAppService employeAppService)
        {
            InitializeComponent();
            DataGridEmployee.ConfigGridChekered();
            DataGridEmployee.ConfigGridOnlyRead();
            DataGridEmployee.Columns.AddRange(GetColumns());
            this.employeeAppService = employeAppService;

        }
        public DataGridViewColumn[] GetColumns()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Name"},
            };

            return colunas;
        }
        public int GetIdSelected()
        {
            return DataGridEmployee.SelectId<int>();
        }

        public void UpdateRegisters()
        {
            var employees = employeeAppService.SelectAllEmployees();

            LoadTable(employees);
        }

        private void LoadTable(List<Employee> employees)
        {
            DataGridEmployee.DataSource = employees;
        }
    }
}
