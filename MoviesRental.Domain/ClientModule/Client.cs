using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.ClientModule
{
    public class Client
    {
        public int id { get; set; }

        public string? ClientName { get; set; }

        public int Telephone { get; set; }

        public Client(int id, string? clientName, int telephone)
        {
            this.id = id;
            ClientName = clientName;
            Telephone = telephone;
        }

        public Client() { }
    }
}
