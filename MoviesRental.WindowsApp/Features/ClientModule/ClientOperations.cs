using MovieRental.Application.ClientModule;
using MoviesRental.Domain.ClientModule;
using MoviesRental.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.WindowsApp.Features.ClientModule
{
    public class ClientOperations: IRegister
    {
        private ClientAppService appService = null;

        private ClientTable clientTable = null;

        public ClientOperations(ClientAppService appService)
        {
            this.appService = appService;
            clientTable = new ClientTable(appService);
        }

        public void InsertNewRegister()
        {
            ClientForm clientForm = new ClientForm();

            if (clientForm.ShowDialog() == DialogResult.OK)
            {
                string result = appService.InsertNewClient(clientForm.Client);

                if (result == "Is_Valid")
                {
                    clientTable.UpdateRegisters();
                    MainForm.instance.UpdateFooter($"Client {clientForm.Client.ClientName} inserted with success");
                }
                else
                {
                    MainForm.instance.UpdateFooter(result);
                }
            }
        }

        public void EditRegister()
        {
            int id = clientTable.GetIdSelected();

            if (id == 0)
            {
                MessageBox.Show("Select a client to edit","Client editing",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Client clientSelected = appService.SelectClientId(id);

            ClientForm screen = new ClientForm();
            screen.Client = clientSelected;
            screen.ShowDialog();
            if (screen.DialogResult == DialogResult.OK)
            {
                string result = appService.EditClient(id, screen.Client);

                if (result == "Is_Valid")
                {
                    clientTable.UpdateRegisters();
                    MainForm.instance.UpdateFooter($"Client: [{screen.Client.ClientName}] edited with success");
                }
                else
                {
                    MainForm.instance.UpdateFooter(result);
                }
            }
        }

        public void DeleteRegister()
        {
            int id = clientTable.GetIdSelected();

            if (id == 0)
            {
                MessageBox.Show("Select a client to delete","Client deleting",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Client clientSelected = appService.SelectClientId(id);

            if (MessageBox.Show($"Do you have sure about to delete: [{clientSelected.ClientName}] ?",
                "Client deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (appService.DeleteClient(id))
                {
                    clientTable.UpdateRegisters();
                    MainForm.instance.UpdateFooter($"Client: [{clientSelected.ClientName}] deleted with success");
                }
                else
                {
                    MainForm.instance.UpdateFooter($"It wasn't possible to delete the client {clientSelected.ClientName}");
                }
            }
        }

        public UserControl GetTable()
        {
            clientTable.UpdateRegisters();

            return clientTable;
        }

        public UserControl GetTableFiltered(string filter)
        {
            throw new NotImplementedException();
        }
    }
}
