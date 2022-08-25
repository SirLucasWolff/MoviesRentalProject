using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MoviesRental.DataBase
{
    public class Connection
    {
        public SqlConnection SqlServerConnection()
        {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Movies Rental Project");

            string pathName = (string)registryKey.GetValue("FrameworkType");

            string databaseType = null;

            if (pathName == "SQLServer")
                databaseType = "DB";
            else
                databaseType = "EF";

            string host = Dns.GetHostName();

            string? ConnectionString = null;

            if (host == "LAPTOP-B893FLT6")
                ConnectionString = $@"Data Source=LAPTOP-B893FLT6\SQLEXPRESS;Initial Catalog=MoviesRental{databaseType};Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            else
                ConnectionString = $@"Data Source=LUCAS\SQLEXPRESS;Initial Catalog=MoviesRental{databaseType};Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection? cnn;

            cnn = new SqlConnection(ConnectionString);

            cnn.Open();

            return cnn;
        }
    }
}
