using MoviesRental.Domain;
using MoviesRental.Domain.ClientModule;
using MoviesRental.Infra.SQL;
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

        public bool InsertNew(Client client)
        {
            try
            {
                DataBaseController.DataBase(SqlInsert, GetParametersClients(client));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }         
        }

        public bool Delete(int id)
        {
            try
            {
                DataBaseController.DataBase(SqlDelete, AddParameters("ID", id));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }          
        }

        private Dictionary<string, object> AddParameters(string v, int id)
        {
            return new Dictionary<string, object>() { { v, id } };
        }

        public bool Edit(int id, Client client)
        {
            try
            {
                DataBaseController.DataBase(SqlEdit, GetParametersClients(client));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }     
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

        public List<Client> SelectAll()
        {
            return DataBaseController.GetAll(SqlSelectAll, ClientConvert);
        }

        public Client SelectById(int id)
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

        public bool ExistClientWithTheName(int id, string name)
        {
            throw new NotImplementedException();
        }

        public bool Exist(int id)
        {
            throw new NotImplementedException();
        }
    }
}
