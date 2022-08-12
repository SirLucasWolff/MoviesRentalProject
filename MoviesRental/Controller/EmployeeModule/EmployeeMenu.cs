using MoviesRental.Domain.EmployeeModule;
using RentalMovies.Screen.EmployeeModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Controller.EmployeeModule
{
    public class EmployeeMenu
    {
        EmployeeScreen employerScreen = new EmployeeScreen();

        EmployeeController employerController = new EmployeeController();

        Employee employer = new Employee();

        public MainController EmployeeOptions()
        {
            employerScreen.EmployeeMenu();

            int EmployerOption = Convert.ToInt32(Console.ReadLine());

            switch (EmployerOption)
            {
                case 1:
                    employerController.AddEmployee(employer);
                    break;
                case 2:
                    employerController.DeleteEmployee(employer.Id);
                    break;
                case 3:
                    employerController.EditEmployee(employer.Id,employer);
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
