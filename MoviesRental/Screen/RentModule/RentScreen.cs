using MoviesRental.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Screen.RentModule
{
    public class RentScreen
    {
        internal void RentMenu()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Rent options");
            Console.ResetColor();
            Console.WriteLine("1 - Register a new rent");
            Console.WriteLine("2 - Delete a rent");
            Console.WriteLine("3 - Edit a rent");
            Console.WriteLine("4 - View the rents");
            Console.WriteLine("5 - Quit");
        }

        public void ShowRents(string commandText)
        {
            Console.Clear();

            SqlCommand getCommand = DataBaseController.ShowController(commandText);

            using (SqlDataReader read = getCommand.ExecuteReader())
            {
                while (read.Read())
                {
                    int id = Convert.ToInt32(read["Id"]);
                    string EmployeName = read["EmployeName"].ToString();
                    string MovieName = read["MovieName"].ToString();
                    string ClientName = read["ClientName"].ToString();
                    DateTime RentalDate = Convert.ToDateTime(read["RentalDate"]);
                    DateTime ReturnDate = Convert.ToDateTime(read["ReturnDate"]);
                    Console.WriteLine($" {id} | {EmployeName} | {MovieName} | {ClientName} | {RentalDate} | {ReturnDate}");
                }
            }
        }
    }
}
