using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Screen
{
    public class MainScreen
    {
        public void MainMenu()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to movies rental");
            Console.ResetColor();
            Console.WriteLine("1 - Employer access");
            Console.WriteLine("2 - Movies management");
            Console.WriteLine("3 - Clients management");
            Console.WriteLine("-------------------------");
            Console.WriteLine("4 - register rent");
        }
    }
}
