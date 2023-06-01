using MovieRental.Application.ClientModule;
using MoviesRental.Domain.ClientModule;
using MoviesRental.WindowsApp.Shared;

namespace MoviesRental.WindowsApp.Features.ClientModule
{
    public class ClientOperations : IRegister
    {
        private ClientAppService appService;

        private ClientTable clientTable;

        public static ClientOperations instance;

        public static List<Client> clientsToMigrate = new List<Client>();

        public ClientOperations(ClientAppService appService)
        {
            instance = this;
            this.appService = appService;
            clientTable = new ClientTable(appService);
        }

        public void GetList()
        {
            List<Client> clients = appService.SelectAllClients();

            clientsToMigrate.AddRange(clients);
        }

        public void InsertNewRegister()
        {
            ClientForm clientForm = new ClientForm(true);

            bool datasRequiredIsNull;

            do
            {
                clientForm.ShowDialog();

                if (clientForm.DialogResult == DialogResult.Cancel)
                    return;

                if (clientForm.DialogResult != DialogResult.OK) return;

                datasRequiredIsNull = String.IsNullOrEmpty(clientForm.Client.ClientName)
                                     | String.IsNullOrEmpty(clientForm.Client.Address)
                                     | clientForm.Client.Telephone == 0
                                     | clientForm.Client.BornDate > new DateTime(2012, 4, 16);

                if (datasRequiredIsNull)
                {
                    MessageBox.Show("There are empty informations", "Client form",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            } while (datasRequiredIsNull);

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

        public void EditRegister()
        {
            int id = clientTable.GetIdSelected();

            if (id == 0)
            {
                MessageBox.Show("Select a client to edit", "Client editing",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Client clientSelected = appService.SelectClientId(id);

            ClientForm screen = new ClientForm(false);

            screen.Client = clientSelected;

            bool datasRequiredIsNull;

            do
            {
                screen.ShowDialog();

                if (screen.DialogResult != DialogResult.OK) return;

                datasRequiredIsNull = String.IsNullOrEmpty(screen.Client.ClientName)
                                     | String.IsNullOrEmpty(screen.Client.Address)
                                     | screen.Client.Telephone == 0
                                     | screen.Client.BornDate > new DateTime(2012, 4, 16);

                if (datasRequiredIsNull)
                {
                    MessageBox.Show("There are empty informations", "Client form",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            } while (datasRequiredIsNull);

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

        public void DeleteRegister()
        {
            int id = clientTable.GetIdSelected();

            if (id == 0)
            {
                MessageBox.Show("Select a client to delete", "Client deleting",
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
