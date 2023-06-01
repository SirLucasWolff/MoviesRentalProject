using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.WindowsApp.Features.RentModule
{
    public interface IRegisterRent
    {
        void InsertNewRegister();

        void RegisterDevolution();

        void EditStatusRegister();

        void DeleteRegister();

        UserControl GetTable();

        UserControl GetTableFiltered(string filter);
    }
}
