using MoviesRental.Domain.RentModule;
using MoviesRental.Infra.SQL.RentModule;
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

namespace MoviesRental.WindowsApp.Features.RentModule
{
    public partial class FilterRentForm : Form
    {
        public FilterRentForm()
        {
            InitializeComponent();
        }

        private void ActiveRentsRD_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm.instance.ConfigPanelRegistersStatusSelected("Active");
        }

        private void RentsNearReturnRB_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm.instance.ConfigPanelRegistersStatusSelected("Near return");
        }

        private void PendingRentsRB_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm.instance.ConfigPanelRegistersStatusSelected("Pending");
        }

        private void ShowAllRentsRB_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm.instance.ConfigPanelRegistersStatusSelected(null);
        }
    }
}
