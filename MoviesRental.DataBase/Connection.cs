using System.Configuration;
using System.Data.SqlClient;
using System.Net;

namespace MoviesRental.DataBase
{
    public class Connection
    {
        public SqlConnection SqlServerConnection()
        {
            SqlConnection? cnn;

            string connectionString = ConfigurationManager.AppSettings["DatabaseConnection"];

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);

            string currentServerName = Dns.GetHostName();

            builder.DataSource = currentServerName + "\\SQLEXPRESS";

            string modifiedConnectionString = builder.ConnectionString;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["DatabaseConnection"].Value = modifiedConnectionString;

            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");

            cnn = new SqlConnection(modifiedConnectionString);

            cnn.Open();

            return cnn;
        }
    }
}
