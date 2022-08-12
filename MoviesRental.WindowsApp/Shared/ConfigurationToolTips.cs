using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.WindowsApp.Shared
{
    public class ConfigurationToolTips
    {
        public ConfigurationToolTips()
        {
            Add = "Add";
            Edit = "Edit";
            Delete = "Delete";
        }

        public string Add { get; internal set; }
        public string Edit { get; internal set; }
        public string Delete { get; internal set; }
    }
}
