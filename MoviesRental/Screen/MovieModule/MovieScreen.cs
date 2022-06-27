using MoviesRental.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Screen.MovieModule
{
    public class MovieScreen
    {
        internal void MovieMenu()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Movie options");
            Console.ResetColor();
            Console.WriteLine("1 - Register a new movie");
            Console.WriteLine("2 - Delete a movie");
            Console.WriteLine("3 - Edit a movie");
            Console.WriteLine("4 - View the movies");
            Console.WriteLine("5 - Quit");
        }

        public void ShowMovies(string commandText)
        {
            Console.Clear();

            SqlCommand getCommand = DataBaseController.ShowController(commandText);

            using (SqlDataReader read = getCommand.ExecuteReader())
            {
                while (read.Read())
                {
                    int id = Convert.ToInt32(read["Id"]);
                    string MovieName = read["MovieName"].ToString();
                    Console.WriteLine($" {id} | {MovieName} ");
                }
            }
        }
    }
}
