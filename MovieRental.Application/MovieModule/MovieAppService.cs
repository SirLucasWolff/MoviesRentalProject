using MoviesRental.Domain.MovieModule;
using MoviesRental.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Application.MovieModule
{
    public class MovieAppService
    {
        MovieRepository movieRepository;

        public MovieAppService(MovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public string InsertNewMovie(Movie movie)
        {
            string ValidationResult = movie.Validation();

            try
            {
                movieRepository.InsertNew(movie);
            }
            catch (Exception ex)
            {
                return "The movie cannot be insert";
            }

            return ValidationResult;
        }

        public string EditMovie(int id, Movie movie)
        {
            string ValidationResult = movie.Validation();

            try
            {
                movie.Id = id;
                movieRepository.Edit(id, movie);
            }
            catch (Exception ex)
            {
                return "The movie cannot be edited";
            }

            return ValidationResult;
        }

        public bool DeleteMovie(int id)
        {
            try
            {
                movieRepository.Delete(id);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public Movie SelectMovieId(int id)
        {
            try
            {
                Movie movieSelected = movieRepository.SelectById(id);
                return movieSelected;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Movie> SelectMovieReference(string name)
        {
            try
            {
                List<Movie> movieSelected = movieRepository.GetByReference(name);
                return movieSelected;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Movie> SelectListByMovieName(string name)
        {
            try
            {
                List<Movie> movieSelected = movieRepository.GetListByName(name);
                return movieSelected;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Movie? SelectMovieByName(Movie movie)
        {
            try
            {
                Movie? movieSelected;

                movieSelected = movieRepository.SelectAll().Find(x => x.Name == movie.Name);
                movieSelected = movieRepository.SelectAll().Find(x => x.Category == movie.Category);
                movieSelected = movieRepository.SelectAll().Find(x => x.Classification == movie.Classification);
                movieSelected = movieRepository.SelectAll().Find(x => x.ReleaseDate == movie.ReleaseDate);

                if (movieSelected == null)
                    return null;

                bool name = movieSelected.Name == movie.Name;
                bool category = movieSelected.Category == movie.Category;
                bool classification = movieSelected.Classification == movie.Classification;
                bool releaseDate = movieSelected.ReleaseDate == movie.ReleaseDate;

                if (name && category && classification && releaseDate)
                    return null;

                if (name || category || classification || releaseDate)
                    return movieSelected;

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Movie> SelectAllMovies()
        {
            try
            {
                List<Movie> allMoviesSelected = movieRepository.SelectAll();
                return allMoviesSelected;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
