using MoviesRental.DataBase;
using MoviesRental.Domain.ClientModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Infra.SQL.ClientModule
{
    public class ClientSQL: ClientRepository
    {
        public string SqlInsert = @"INSERT INTO ClientDB
                    (
                        [ClientName],
                        [Telephone],
                        [Address],
                        [BornDate]
                    )
                    VALUES
                    (
                        @ClientName,
                        @Telephone,
                        @Address,
                        @BornDate
                    )";

        public string SqlSelect = @"SELECT * FROM ClientDB";

        public string SqlDelete = @"DELETE FROM ClientDB WHERE ID = @Id";

        public string SqlEdit = @"UPDATE ClientDB
                    SET
                        [ClientName] = @ClientName,
                        [Telephone] = @Telephone,
                        [ADDRESS] = @Address,
                        [BORNDATE] = @BornDate
                    WHERE 
                        ID = @ID";

        public string SqlSelectId = @"SELECT
                        [ID],
                        [CLIENTNAME],
                        [TELEPHONE],
                        [ADDRESS],
                        [BORNDATE]
	                FROM
                        ClientDB
                    WHERE 
                        ID = @ID";

        public string SqlSelectAll =
        @"SELECT
                        [ID],
                        [CLIENTNAME],
                        [TELEPHONE],
                        [ADDRESS],
                        [BORNDATE]
          
                        FROM ClientDB";

        public void AddClient(Client client)
        {
           DataBaseController.DataBase(SqlInsert, GetParametersClients(client));
        }

        public void DeleteClient(int id)
        {
            DataBaseController.DataBase(SqlDelete, AddParameters("ID", id));
        }

        private Dictionary<string, object> AddParameters(string v, int id)
        {
            return new Dictionary<string, object>() { { v, id } };
        }

        public void EditClient(int id, Client client)
        {
            DataBaseController.DataBase(SqlEdit, GetParametersClients(client));
        }

        private Dictionary<string, object> GetParametersClients(Client client)
        {
            var parameters = new Dictionary<string, object>();

            parameters.Add("ID", client.Id);
            parameters.Add("CLIENTNAME", client.ClientName);
            parameters.Add("TELEPHONE", client.Telephone);
            parameters.Add("ADDRESS", client.Address);
            parameters.Add("BORNDATE", client.BornDate);

            return parameters;
        }

        public List<Client> GetAll()
        {
            return DataBaseController.GetAll(SqlSelectAll, ClientConvert);
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
            DateTime ageDate = Convert.ToDateTime(reader["BORNDATE"]);

            Client client = new Client(clientName, telephone, address, ageDate);

            client.Id = id;

            return client;
        }
    }
}
