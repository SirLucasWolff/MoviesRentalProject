using MoviesRental.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.WindowsApp.Features.ClientModule
{
    public class ClientConfigurationToolBox : IConfigurationToolBox
    {
        public string KindRegister
        {
            get { return "Client Register"; }
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
                Add = "Add a new client",
                Edit = "Edit a client",
                Delete = "Delete a client",
            };
        }
    }
}
