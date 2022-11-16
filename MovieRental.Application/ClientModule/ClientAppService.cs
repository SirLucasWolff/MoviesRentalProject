using MoviesRental.Domain.ClientModule;
using MoviesRental.Domain.MovieModule;
using MoviesRental.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Application.ClientModule
{
    public class ClientAppService
    {
        ClientRepository clientRepository;

        public ClientAppService(ClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        public string InsertNewClient(Client client)
        {
            string ValidationResult = client.Validation();

            try
            {
                clientRepository.InsertNew(client);
            }
            catch (Exception ex)
            {
                return "The client cannot be insert";
            }

            return ValidationResult;
        }

        public string EditClient(int id, Client client)
        {
            string ValidationResult = client.Validation();

            try
            {
                client.Id = id;
                clientRepository.Edit(id, client);
            }
            catch (Exception ex)
            {
                return "The client cannot be edited";
            }

            return ValidationResult;
        }

        public bool DeleteClient(int id)
        {
            try
            {
                clientRepository.Delete(id);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public Client SelectClientId(int id)
        {
            try
            {
                Client clientSelected = clientRepository.SelectById(id);
                return clientSelected;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Client? SelectClientByName(Client client)
        {
            try
            {
                Client? clientSelected;

                clientSelected = clientRepository.SelectAll().Find(x => x.ClientName == client.ClientName);
                clientSelected = clientRepository.SelectAll().Find(x => x.Telephone == client.Telephone);
                clientSelected = clientRepository.SelectAll().Find(x => x.Address == client.Address);
                clientSelected = clientRepository.SelectAll().Find(x => x.BornDate == client.BornDate);

                if (clientSelected == null)
                    return null;

                bool name = clientSelected.ClientName == client.ClientName;
                bool telephone = clientSelected.Telephone == client.Telephone;
                bool address = clientSelected.Address == client.Address;
                bool bornDate = clientSelected.BornDate == client.BornDate;

                if (name && telephone && address && bornDate)
                    return null;

                if (name || telephone || address || bornDate)
                    return clientSelected;

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Client>? SelectAllClients()
        {
            try
            {
                List<Client> allClientsSelected = clientRepository.SelectAll();
                return allClientsSelected;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
