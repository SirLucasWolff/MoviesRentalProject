using MoviesRental.Domain.MovieModule;
using MoviesRental.Domain.RentModule;
using MoviesRental.Infra.ORM.MoviesRentalModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Infra.ORM.RentModule
{
    public class RentOrmDAO : BaseRepository<Rent, int>, RentRepository
    {
        MoviesRentalDbContext moviesRentalDbContext;
        public RentOrmDAO(MoviesRentalDbContext moviesRentalDbContext) : base(moviesRentalDbContext)
        {
            this.moviesRentalDbContext = moviesRentalDbContext;
        }

        public bool ExistRentWithTheName(int id, string name)
        {
            var RentList = moviesRentalDbContext.RentDB.ToList();
            if (RentList == null)
            {
                return false;
            }
            else
            {
                return RentList.Exists(x => x.ClientName == name);
            }
        }
    }
}
