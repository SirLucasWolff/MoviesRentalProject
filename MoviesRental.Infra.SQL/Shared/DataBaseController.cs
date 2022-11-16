using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using MoviesRental.DataBase;

namespace MoviesRental.Infra.SQL
{
    public delegate T ConvertToDelegate<T>(IDataReader reader);
    public static class DataBaseController
    {
        static Connection connection = new Connection();

        static SqlCommand cmd = new SqlCommand();

        public static string GetTablesSqlServer()
        {
            string? Tables = $"CREATE TABLE EMPLOYEDB" +
                $"(" +
                $"Name nvarchar(50) NOT NULL," +
                $"Password nvarchar(50) NOT NULL" +
                $");" +
                $"CREATE TABLE MOVIEDB" +
                $"(" +
                $"MovieName nvarchar(100) NOT NULL" +
                $")" +
                $"CREATE TABLE CLIENTDB" +
                $"(" +
                $"ClientName nvarchar(50) NOT NULL," +
                $"Telephone int NOT NULL" +
                $")" +
                $"CREATE TABLE RENTDB" +
                $"(" +
                $"EmployerName nvarchar(50) NOT NULL," +
                $"MovieName nvarchar(100) NOT NULL," +
                $"ClientName nvarchar(50) NOT NULL" +
                $");";

            return Tables;
        }

        public static void CreateTablesSqlServer()
        {
            try
            {
                cmd.Connection = connection.SqlServerConnection();

                cmd.CommandText = GetTablesSqlServer();

                cmd.ExecuteNonQuery();

                connection.SqlServerConnection().Close();
            }
            catch { }
        }

        public static void DataBase(string commandText, Dictionary<string, object> parameters = null)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection.SqlServerConnection();

            cmd.CommandText = commandText;
            cmd.Connection = connection.SqlServerConnection();
            cmd.SetParameters(parameters);

            cmd.ExecuteNonQuery();

            connection.SqlServerConnection().Close();
        }

        public static void DataBaseMigration(string commandText, Dictionary<string, object> parameters = null)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection.SqlServerConnection();

            cmd.CommandText = commandText;
            cmd.Connection = connection.SqlServerConnection();
            cmd.SetParameters(parameters);

            cmd.ExecuteNonQuery();

            connection.SqlServerConnection().Close();
        }

        private static void SetParameters(this IDbCommand command, Dictionary<string, object> parameters)
        {
            if (parameters == null || parameters.Count == 0)
                return;

            foreach (var parameter in parameters)
            {
                string name = parameter.Key;

                object value = parameter.Value.IsNullOrEmpty() ? DBNull.Value : parameter.Value;

                IDataParameter dbParameter = command.CreateParameter();

                dbParameter.ParameterName = name;
                dbParameter.Value = value;

                command.Parameters.Add(dbParameter);
            }
        }

        public static bool IsNullOrEmpty(this object value)
        {
            return (value is string && string.IsNullOrEmpty((string)value)) ||
                    value == null;
        }

        public static SqlCommand ShowController(string queryString)
        {
            cmd.Connection = connection.SqlServerConnection();

            SqlCommand command = new SqlCommand(queryString, cmd.Connection);

            return command;
        }

        public static T GetId<T> (string commandText, ConvertToDelegate<T> convert, Dictionary<string, object> parameters)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection.SqlServerConnection();

            cmd.CommandText = commandText;
            cmd.Connection = connection.SqlServerConnection();
            cmd.SetParameters(parameters);

            T t = default;

            using (IDataReader reader = cmd.ExecuteReader())
            {

                if (reader.Read())
                    t = convert(reader);

                return t;
            }
        }

        public static List<T> GetAll<T>(string sqlSelectAll, ConvertToDelegate<T> convert, Dictionary<string, object> parameters = null)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection.SqlServerConnection();

            cmd.CommandText = sqlSelectAll;
            cmd.Connection = connection.SqlServerConnection();
            cmd.SetParameters(parameters);

            var list = new List<T>();

            using (IDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var obj = convert(reader);
                    list.Add(obj);
                }

                return list;
            }
        }
    }
}
