using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.DataBase
{
    public class Connection
    {
        public SqlConnection SqlServerConnection()
        {
            string? ConnectionString;

            ConnectionString = @"Data Source=LAPTOP-B893FLT6\SQLEXPRESS;Initial Catalog=MoviesRentalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection? cnn;

            cnn = new SqlConnection(ConnectionString);

            cnn.Open();

            return cnn;
        }
    }
}
