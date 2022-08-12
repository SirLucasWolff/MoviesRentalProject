using MoviesRental.DataBase;
using MoviesRental.Domain.ClientModule;
using RentalMovies.Screen.ClientModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Controller.ClientModule
{
    public class ClientController : ClientRepository
    {
        ClientScreen clientScreen = new ClientScreen();

        List<Client> clientList = new List<Client>();

        public string SqlInsert = @"INSERT INTO CLIENTDB
                    (
                        [ClientName],
                        [Telephone],
                        [Address],
                        [AgeDate]
                    )
                    VALUES
                    (
                        @ClientName,
                        @Telephone,
                        @Address,
                        @AgeDate
                    )";

        public string SqlSelect = @"SELECT * FROM CLIENTDB";

        public string SqlDelete = @"DELETE FROM CLIENTDB WHERE ID = @Id";

        public string SqlEdit = @"UPDATE CLIENTDB
                    SET
                        [ClientName] = @ClientName,
                        [Telephone] = @Telephone,
                        [Address] = @Address,
                        [AgeDate] = @AgeDate
                    WHERE 
                        ID = @ID";

        public string SqlSelectId = @"SELECT
                        [ID],
                        [CLIENTNAME],
                        [TELEPHONE],
                        [ADDRESS],
                        [AGEDATE]
	                FROM
                        CLIENTDB
                    WHERE 
                        ID = @ID";

        public string SqlSelectAll =
        @"SELECT
                        [ID],
                        [CLIENTNAME],
                        [TELEPHONE],
                        [ADDRESS],
                        [AGEDATE]
          
                        FROM CLIENTDB";

        public void AddClient(Client client)
        {
            Console.Clear();

            Random rnd = new Random();
            client.Id = rnd.Next();

            Console.WriteLine("Insert the client name:");
            client.ClientName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insert the client telephone:");
            client.Telephone = Convert.ToInt32(Console.ReadLine());

            DataBaseController.DataBase(SqlInsert, GetParametersClients(client));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Client created with success");
            Console.ReadLine();
            Console.ResetColor();
        }

        public void DeleteClient(int id)
        {
            Console.Clear();

            ShowClients();

            Console.WriteLine("Select the client id to delete:");
            id = Convert.ToInt32(Console.ReadLine());

            DataBaseController.DataBase(SqlDelete, AddParameters("ID", id));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Client deleted with success");
            Console.ReadLine();
            Console.ResetColor();
        }

        public void EditClient(int id, Client client)
        {
            Console.Clear();

            ShowClients();

            Console.WriteLine("Select the client id to edit:");
            id = Convert.ToInt32(Console.ReadLine());

            client = GetById(id);

            Console.WriteLine("1 - Edit the name");
            Console.WriteLine("2 - Edit the telephone");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Insert the new name");
                    client.ClientName = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Insert the new telephone");
                    client.Telephone = Convert.ToInt32(Console.ReadLine());
                    break;
            }

            DataBaseController.DataBase(SqlEdit, GetParametersClients(client));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Client edited with success");
            Console.ReadLine();
            Console.ResetColor();
        }

        internal void ShowClients()
        {
            clientScreen.ShowClients(SqlSelect);
        }

        private Dictionary<string, object> AddParameters(string v, int id)
        {
            return new Dictionary<string, object>() { { v, id } };
        }

        private Dictionary<string, object> GetParametersClients(Client client)
        {
            var parameters = new Dictionary<string, object>();

            parameters.Add("ID", client.Id);
            parameters.Add("CLIENTNAME", client.ClientName);
            parameters.Add("TELEPHONE", client.Telephone);

            return parameters;
        }

        public Client GetById(int id)
        {
            return DataBaseController.GetId(SqlSelectId, ClientConvert, AddParameters("ID", id));
        }

        private Client ClientConvert(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string clientName = ((string)reader["CLIENTNAME"]);
            int telephone = Convert.ToInt32(reader["TELEPHONE"]);
            string address = ((string)reader["ADDRESS"]);
            DateTime ageDate = Convert.ToDateTime(reader["AGEDATE"]);

            Client client = new Client(id,clientName, telephone, address, ageDate);

            client.Id = id;

            return client;
        }

        public List<Client> GetAll()
        {
            return DataBaseController.GetAll(SqlSelectAll, ClientConvert);
        }

        public bool Validation(string value)
        {
            clientList = GetAll();

            foreach (var item in clientList)
            {
                if (item.ClientName == value)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
