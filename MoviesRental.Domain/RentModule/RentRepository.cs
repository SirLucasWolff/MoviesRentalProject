using MoviesRental.Domain.MovieModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.RentModule
{
    public interface RentRepository : IRepository<Rent, int>, IReadOnlyRepository<Rent, int>
    {
        public bool ExistRentWithTheName(int id, string name);
    }
}
