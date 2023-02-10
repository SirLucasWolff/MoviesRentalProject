using MovieRental.Application.RentModule;
using MoviesRental.Domain.RentModule;
using MoviesRental.WindowsApp.Features.RentModule;
using MoviesRental.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesRental.WindowsApp.Features.AccountModule
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();

            InitialInformations();

            DashboardInformations();
        }

        private void InitialInformations()
        {
            ActiveRentsQuantity.Text = "0";

            PendingRentsQuantity.Text = "0";

            ExpiredRentsQuantity.Text = "0";
        }

        private void DashboardInformations()
        {
            List<Rent> activeRents = new RentInformations().rents;

            List<Rent> pendingRents = new List<Rent>();

            List<Rent> expiredRents = new List<Rent>();

            ActiveRentsQuantity.Text = activeRents.Count.ToString();

            foreach (Rent rent in activeRents) 
            {
                if (rent.Status == "Near return")
                    pendingRents.Add(rent);

                if(rent.Status == "Pending")
                    expiredRents.Add(rent);
            }

            PendingRentsQuantity.Text = pendingRents.Count.ToString();

            ExpiredRentsQuantity.Text = expiredRents.Count.ToString();
        }

        private void DashboardRefreshButton_Click(object sender, EventArgs e)
        {
            DashboardInformations();
        }
    }
}
