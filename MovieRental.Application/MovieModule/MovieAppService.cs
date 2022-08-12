using MoviesRental.Domain.MovieModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Application.MovieModule
{
    public class MovieAppService
    {
        MovieRepository movieRepository;

        public MovieAppService (MovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public string InsertNewMovie(Movie movie)
        {
            string ValidationResult = movie.Validation();

            try
            {
                movieRepository.AddMovie(movie);
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
                movieRepository.EditMovie(id, movie);
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
                movieRepository.DeleteMovie(id);
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
                Movie movieSelected = movieRepository.GetById(id);
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

        public List<Movie> SelectMovieName(string name)
        {
            try
            {
                List<Movie> movieSelected = movieRepository.GetByName(name);
                return movieSelected;
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
                List<Movie> allMoviesSelected = movieRepository.GetAll();
                return allMoviesSelected;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
