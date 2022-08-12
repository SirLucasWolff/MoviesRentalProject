using RentalMovies.Controller.ClientModule;
using RentalMovies.Controller.EmployeeModule;
using RentalMovies.Controller.MovieModule;
using RentalMovies.Controller.RentModule;
using RentalMovies.Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Controller
{
    public class MainController
    {
        MainScreen mainScreen = new MainScreen();

        MovieMenu movieController = new MovieMenu();

        ClientMenu clientController = new ClientMenu();

        RentMenu rentController = new RentMenu();

        EmployeeMenu employerController = new EmployeeMenu();

        public int optionNumber = 10;

        public bool MainOptions()
        {
            while(optionNumber != 0)
            {
                mainScreen.MainMenu();

                optionNumber = Convert.ToInt32(Console.ReadLine());

                if (optionNumber == 1)
                    employerController.EmployeeOptions();

                if (optionNumber == 2)
                    movieController.MovieOptions();

                if (optionNumber == 3)
                    clientController.ClientOptions();

                if (optionNumber == 4)
                    rentController.RentOptions();
            }

            return false;

        }
    }
}
