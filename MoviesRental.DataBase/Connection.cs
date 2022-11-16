﻿using Microsoft.Win32;
using MoviesRental.Domain.Shared;
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
            string host = Dns.GetHostName();

            string value;

            if (FrameworkConfiguration.FrameworkTypeRead() == "SQLServer")
                value = "DB";
            else
                value = "EF";

            string? ConnectionString = null;

            if (host == "LAPTOP-B893FLT6")
                ConnectionString = $@"Data Source=LAPTOP-B893FLT6\SQLEXPRESS;Initial Catalog=MoviesRental{value};Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            else
                ConnectionString = $@"Data Source=LUCASWOLFF\SQLEXPRESS;Initial Catalog=MoviesRental{value};Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection? cnn;

            cnn = new SqlConnection(ConnectionString);

            cnn.Open();

            return cnn;
        }
    }
}
