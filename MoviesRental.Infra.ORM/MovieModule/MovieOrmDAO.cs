using MoviesRental.Domain.MovieModule;
using MoviesRental.Infra.ORM.MoviesRentalModule;

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

        public List<Movie> GetListByName(string name)
        {
            List<Movie> MovieList = moviesRentalDbContext.MovieDB.ToList();

            List<Movie> MoviesByName = new List<Movie>();

            foreach (var Movie in MovieList)
            {
                if (Movie.Name == name)
                    MoviesByName.Add(Movie);
            }

            return MoviesByName;
        }

        public List<Movie> GetByReference(string name)
        {
            try
            {
                char[] delimeters = new char[] { '%' };

                var nameFormated = name.Split(delimeters);

                string getNewName = null;

                foreach (var item in nameFormated)
                {
                    if (item != "")
                        getNewName = item;
                }

                List<Movie> movieSelected = moviesRentalDbContext.MovieDB.ToList();

                if (getNewName == null)
                    return movieSelected;

                bool result = false;

                List<Movie> returMovies = new List<Movie>();

                foreach (var movie in movieSelected)
                {
                    result = movie.Name.ToLower().Contains(getNewName);

                    if (result != false)
                        returMovies.Add(movie);
                }

                return returMovies;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Movie GetByName(string name)
        {
            Movie MovieList = moviesRentalDbContext.MovieDB.ToList().Find(x => x.Name == name);

            return MovieList;
        }
    }
}
