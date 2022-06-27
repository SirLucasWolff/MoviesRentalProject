using MoviesRental.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Screen.ClientModule
{
    public class ClientScreen
    {
        internal void ClientMenu()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Client options");
            Console.ResetColor();
            Console.WriteLine("1 - Create a new client");
            Console.WriteLine("2 - Delete a client");
            Console.WriteLine("3 - Edit a client");
            Console.WriteLine("4 - View the clients");
            Console.WriteLine("5 - Quit");
        }

        public void ShowClients(string commandText)
        {
            Console.Clear();

            SqlCommand getCommand = DataBaseController.ShowController(commandText);

            using (SqlDataReader read = getCommand.ExecuteReader())
            {
                while (read.Read())
                {
                    int id = Convert.ToInt32(read["Id"]);
                    string Name = read["ClientName"].ToString();
                    string Telephone = read["Telephone"].ToString();
                    Console.WriteLine($" {id} | {Name} | {Telephone}");
                }
            }
        }
    }
}
