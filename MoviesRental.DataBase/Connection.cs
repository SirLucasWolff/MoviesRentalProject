using System.Configuration;
using System.Data.SqlClient;

namespace MoviesRental.DataBase
{
    public class Connection
    {
        public SqlConnection SqlServerConnection()
        {
            SqlConnection? cnn;

            cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString());

            cnn.Open();

            return cnn;
        }
    }
}
