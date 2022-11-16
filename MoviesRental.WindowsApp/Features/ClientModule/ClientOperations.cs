﻿using Autofac;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using MovieRental.Application.ClientModule;
using MoviesRental.Domain.ClientModule;
using MoviesRental.Domain.EmployeeModule;
using MoviesRental.Domain.MovieModule;
using MoviesRental.Domain.Shared;
using MoviesRental.Infra.ORM;
using MoviesRental.Infra.SQL;
using MoviesRental.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                MessageBox.Show("Select a client to edit", "Client editing",
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

        public void MigrateRegister()
        {
            foreach (Client clientToMigrate in clientsToMigrate)
            {
                Client? clientToEdit = appService.SelectClientByName(clientToMigrate);

                clientToMigrate.Id = 0;

                string? getResult = ValidateMigrate(clientToMigrate);

                if (getResult == "InsertingWhileMigrate")
                    appService.InsertNewClient(clientToMigrate);

                if (getResult == "EditingWhileMigrate" && clientToEdit != null)
                    appService.EditClient(clientToEdit.Id, clientToMigrate);
            }
        }

        private string? ValidateMigrate(Client client)
        {
            List<Client> allClients = appService.SelectAllClients();

            if (allClients.Count == 0)
                return "InsertingWhileMigrate";

            bool name = allClients.Exists(d => d.ClientName == client.ClientName);
            bool address = allClients.Exists(d => d.Address == client.Address);
            bool bornDate = allClients.Exists(d => d.BornDate == client.BornDate);
            bool telephone = allClients.Exists(d => d.Telephone == client.Telephone);

            if (!name && !address && !bornDate && !telephone)
                return "InsertingWhileMigrate";

            if (name || telephone || address || bornDate)
                return "EditingWhileMigrate";

            return null;
        }
    }
}
