using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.WindowsApp.Shared
{
    public class ConfigButtonState
    {
        public ConfigButtonState()
        {
            Add = true;
            Edit = true;
            Delete = true;
        }

        public bool Add { get; internal set; }
        public bool Edit { get; internal set; }
        public bool Delete { get; internal set; }
    }
}
