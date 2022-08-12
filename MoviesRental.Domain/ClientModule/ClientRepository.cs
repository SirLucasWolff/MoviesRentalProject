using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.ClientModule
{
    public interface ClientRepository
    {
        Client GetById(int id);

        void AddClient(Client client);

        void DeleteClient(int id);

        void EditClient(int id, Client client);

        List<Client> GetAll();
    }
}
