using MoviesRental.Domain.EmployeeModule;
using MoviesRental.Domain.MovieModule;
using MoviesRental.Infra.ORM.MoviesRentalModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Infra.ORM.MovieModule
{
    public class MovieOrmDAO : BaseRepository<Movie, int>, MovieRepository
    {
        MoviesRentalDbContext moviesRentalDbContext;
        public MovieOrmDAO(MoviesRentalDbContext moviesRentalDbContext) : base(moviesRentalDbContext)
        {
            this.moviesRentalDbContext = moviesRentalDbContext;
        }

        public bool ExistMovieWithTheName(int id, string name)
        {
            var MovieList = moviesRentalDbContext.MovieDB.ToList();
            if (MovieList == null)
            {
                return false;
            }
            else
            {
                return MovieList.Exists(x => x.Name == name);
            }
        }

        public List<Movie> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetByReference(string name)
        {
            throw new NotImplementedException();
        }
    }
}
