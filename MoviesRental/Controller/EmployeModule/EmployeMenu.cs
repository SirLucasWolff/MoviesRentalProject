using MoviesRental.Domain.EmployeModule;
using RentalMovies.Screen.EmployeModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Controller.EmployeModule
{
    public class EmployeMenu
    {
        EmployeScreen employerScreen = new EmployeScreen();

        EmployeController employerController = new EmployeController();

        Employe employer = new Employe();

        public MainController EmployerOptions()
        {
            employerScreen.EmployerMenu();

            int EmployerOption = Convert.ToInt32(Console.ReadLine());

            switch (EmployerOption)
            {
                case 1:
                    employerController.AddEmploye(employer);
                    break;
                case 2:
                    employerController.DeleteEmploye(employer.id);
                    break;
                case 3:
                    employerController.EditEmploye(employer.id,employer);
                    break;
                case 4:
                    employerController.ShowEmployees();
                    Console.ReadLine();
                    break;
                case 5:
                    break;
            }

            return new MainController();
        }
    }
}
