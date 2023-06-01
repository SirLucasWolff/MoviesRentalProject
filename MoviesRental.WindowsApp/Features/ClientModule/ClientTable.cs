using MovieRental.Application.ClientModule;
using MoviesRental.Domain.ClientModule;
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

namespace MoviesRental.WindowsApp.Features.ClientModule
{
    public partial class ClientTable : UserControl
    {
        private readonly ClientAppService clientAppService;
        public ClientTable(ClientAppService clientAppService)
        {
            InitializeComponent();
            DataGridClient.ConfigGridChekered();
            DataGridClient.ConfigGridOnlyRead();
            DataGridClient.Columns.AddRange(GetColumns());
            this.clientAppService = clientAppService;

        }
        public DataGridViewColumn[] GetColumns()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ClientName", HeaderText = "Name"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Telephone", HeaderText = "Telephone"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Address", HeaderText = "Address"},
            };

            return colunas;
        }
        public int GetIdSelected()
        {
            return DataGridClient.SelectId<int>();
        }

        public void UpdateRegisters()
        {

            var clients = clientAppService.SelectAllClients();

            LoadTable(clients);

        }

        private void LoadTable(List<Client> clients)
        {
            DataGridClient.DataSource = clients;
        }
    }
}
