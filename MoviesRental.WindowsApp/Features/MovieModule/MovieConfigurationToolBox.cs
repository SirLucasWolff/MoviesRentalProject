using MoviesRental.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.WindowsApp.Features.MovieModule
{
    public class MovieConfigurationToolBox : IConfigurationToolBox
    {
        public string KindRegister
        {
            get { return "Movie Register"; }
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
                Add = "Add a new movie",
                Edit = "Edit a movie",
                Delete = "Delete a movie",
            };
        }
    }
}
