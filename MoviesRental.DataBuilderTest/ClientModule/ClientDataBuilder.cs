using MoviesRental.Domain.ClientModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.DataBuilderTest.ClientModule
{
    public class ClientDataBuilder
    {
        private Client client;

        public Client Build()
        {
            return client;
        }

        public ClientDataBuilder ()
        {
            client = new Client();
        }

        public ClientDataBuilder WithClientName(string name)
        {
            client.ClientName = name;
            return this;
        }

        public ClientDataBuilder WithTelephone(int telephone)
        {
            client.Telephone = telephone;
            return this;
        }

        public ClientDataBuilder WithAddress(string address)
        {
            client.Address = address;
            return this;
        }

        public ClientDataBuilder WithBornDate(DateTime date)
        {
            client.BornDate = date;
            return this;
        }

        public Client GenerateCompleteClient()
        {
            return this.WithClientName("testName")
                .WithTelephone(5565985)
                .WithBornDate(DateTime.Now)
                .WithAddress("testName").Build();
        }

    }
}
