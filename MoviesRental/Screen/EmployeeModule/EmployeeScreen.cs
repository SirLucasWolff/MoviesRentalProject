using MoviesRental.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Screen.EmployeeModule
{
    public class EmployeeScreen
    {
        public void EmployeeMenu()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Employer options");
            Console.ResetColor();
            Console.WriteLine("1 - Create a new employee");
            Console.WriteLine("2 - Delete a employee");
            Console.WriteLine("3 - Edit a employee");
            Console.WriteLine("4 - View the employees");
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
