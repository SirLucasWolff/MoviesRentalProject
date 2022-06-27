using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.MovieModule
{
    public interface MovieRepository
    {
        Movie GetById(int id);

        void AddMovie(Movie movie);

        void DeleteMovie(int id);

        void EditMovie(Movie movie);
    }
}
