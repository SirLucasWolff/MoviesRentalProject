using MoviesRental.Domain.RentModule;
using RentalMovies.Screen.RentModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Controller.RentModule
{
    public class RentMenu
    {
        RentScreen rentScreen = new RentScreen();

        RentController rentController = new RentController();

        Rent rent = new Rent();

        public MainController RentOptions()
        {
            rentScreen.RentMenu();

            int RentOption = Convert.ToInt32(Console.ReadLine());

            switch (RentOption)
            {
                case 1:
                    rentController.AddRent(rent);
                    break;
                case 2:
                    rentController.DeleteRent(rent.Id);
                    break;
                case 3:
                    rentController.EditRent(rent.Id,rent);
                    break;
                case 4:
                    rentController.ShowRents();
                    Console.ReadLine();
                    break;
                case 5:
                    break;
            }

            return new MainController();
        }
    }
}
