using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.WindowsApp.Shared
{
    public interface IConfigurationToolBox
    {
        string KindRegister { get; }
        string GetDescription();
        ConfigurationToolTips GetToolTips();
        ConfigButtonState GetButtonsSate();
    }
}
