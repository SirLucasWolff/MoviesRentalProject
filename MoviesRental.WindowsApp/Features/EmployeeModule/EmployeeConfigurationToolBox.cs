using MoviesRental.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.WindowsApp.Features.EmployeeModule
{
    public class EmployeeConfigurationToolBox: IConfigurationToolBox
    {
        public string KindRegister
        {
            get { return "Employee Register"; }
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
                Add = "Add a new employee",
                Edit = "Edit a employee",
                Delete = "Delete a employee",
            };
        }
    }
}
