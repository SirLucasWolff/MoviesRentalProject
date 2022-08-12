using MovieRental.Application.RentModule;
using MoviesRental.Domain.RentModule;
using MoviesRental.Infra.SQL.RentModule;
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

namespace MoviesRental.WindowsApp.Features.RentModule
{
    public partial class RentTable : UserControl
    {
        private readonly RentAppService rentAppService;

        public RentSQL rentSQL;

        public RentTable(RentAppService rentAppService)
        {
            InitializeComponent();
            DataGridRent.ConfigGridChekered();
            DataGridRent.ConfigGridOnlyRead();
            DataGridRent.Columns.AddRange(GetColumns());
            this.rentAppService = rentAppService;
            rentSQL = new RentSQL();
        }

        public DataGridViewColumn[] GetColumns()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "EmployeName", HeaderText = "Employee"},

                new DataGridViewTextBoxColumn { DataPropertyName = "MoviesQuantity", HeaderText = "Movies quantity"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ClientName", HeaderText = "Client name"},

                new DataGridViewTextBoxColumn { DataPropertyName = "RentalDate", HeaderText = "Rental date"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ReturnDate", HeaderText = "Return date"},

                new DataGridViewTextBoxColumn { DataPropertyName = "TotalPrice", HeaderText = "Total price"},

                new DataGridViewImageColumn   { DataPropertyName = "StatusImage", HeaderText = "Status"},

            };

            return colunas;
        }
        public int GetIdSelected()
        {
            return DataGridRent.SelectId<int>();
        }

        public void UpdateRegisters()
        {
            var rents = rentAppService.SelectAllRents();

            LoadTable(rents);
        }

        public void UpdateRegistersStatusSelected(string status)
        {
            var rents = rentSQL.GetByStatus(status);

            LoadTable(rents);
        }

        public void LoadTable(List<Rent> rents)
        {
            DataGridRent.DataSource = rents;
        }
    }
}
