using MoviesRental.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.WindowsApp.Features.RentModule
{
    public class RentConfigurationToolBox: IConfigurationToolBox
    {
        public string KindRegister
        {
            get { return "Rent Register"; }
        }

        public ConfigButtonState GetButtonsSate()
        {
            return new ConfigButtonState()
            {
            };
        }

        public string GetDescription()
        {
            return KindRegister;
        }

        public ConfigurationToolTips GetToolTips()
        {
            return new ConfigurationToolTips()
            {
                Add = "Add a new rent",
                Edit = "Edit a rent",
                Delete = "Delete a rent",
            };
        }
    }
}
