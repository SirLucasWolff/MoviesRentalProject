using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.RentModule
{
    public interface RentRepository
    {
        Rent GetById(int id);

        void AddRent(Rent movie);

        void DeleteRent(int id);

        void EditRent(int id,Rent movie);
    }
}
