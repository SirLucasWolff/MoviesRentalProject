using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.WindowsApp.Shared
{
    public interface IRegister
    {
        void InsertNewRegister();

        void EditRegister();

        void MigrateRegister();

        void DeleteRegister();

        UserControl GetTable();

        UserControl GetTableFiltered(string filter);
    }
}
