using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.WindowsApp.Shared
{
    public class InternetConnection
    {
        public bool TestConnection()
        {
            bool connection = NetworkInterface.GetIsNetworkAvailable();

            if (connection == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
