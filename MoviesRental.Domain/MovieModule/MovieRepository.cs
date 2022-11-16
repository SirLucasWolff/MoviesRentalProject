using MoviesRental.Domain.EmployeeModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.MovieModule
{
    public interface MovieRepository : IRepository<Movie, int>, IReadOnlyRepository<Movie, int>
    {
        public bool ExistMovieWithTheName(int id, string name);

        List<Movie> GetByReference(string name);

        List<Movie> GetListByName(string name);

        Movie GetByName(string name);
    }
}
