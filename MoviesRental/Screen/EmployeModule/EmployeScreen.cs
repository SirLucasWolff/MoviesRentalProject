using MoviesRental.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Screen.EmployeModule
{
    public class EmployeScreen
    {
        public void EmployerMenu()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Employer options");
            Console.ResetColor();
            Console.WriteLine("1 - Create a new employer");
            Console.WriteLine("2 - Delete a employer");
            Console.WriteLine("3 - Edit a employer");
            Console.WriteLine("4 - View the employers");
            Console.WriteLine("5 - Quit");
        }

        public void ShowEmployees(string commandText)
        {
            Console.Clear();

            SqlCommand getCommand = DataBaseController.ShowController(commandText);

            using (SqlDataReader read = getCommand.ExecuteReader())
            {
                while (read.Read())
                {
                    int id = Convert.ToInt32(read["Id"]);
                    string Name = read["Name"].ToString();
                    string Password = read["Password"].ToString();
                    Console.WriteLine($" {id} | {Name} | {Password}");
                }
            }
        }
    }
}
