using MoviesRental.Domain.RentModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.WindowsApp.Shared
{
    public class RentInformations
    {
        public List<Rent> rents = MainForm.instance.DashboardRents();
    }
}
