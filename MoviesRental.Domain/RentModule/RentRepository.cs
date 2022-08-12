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

        List<Rent> GetByStatus(string status);

        void AddRent(Rent rent);

        void DeleteRent(int id);

        void EditRent(int id,Rent rent);

        List<Rent> GetAll();
    }
}
