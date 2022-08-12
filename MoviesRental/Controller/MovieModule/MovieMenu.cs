using MoviesRental.Domain.MovieModule;
using RentalMovies.Screen.MovieModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Controller.MovieModule
{
    public class MovieMenu
    {
        MovieScreen movieScreen = new MovieScreen();

        MovieController movieController = new MovieController();

        Movie movie = new Movie();

        public MainController MovieOptions()
        {
            movieScreen.MovieMenu();

            int MovieOption = Convert.ToInt32(Console.ReadLine());

            switch (MovieOption)
            {
                case 1:
                    movieController.AddMovie(movie);
                    break;
                case 2:
                    movieController.DeleteMovie(movie.id);
                    break;
                case 3:
                    movieController.EditMovie(movie.id,movie);
                    break;
                case 4:
                    movieController.ShowMovies();
                    Console.ReadLine();
                    break;
                case 5:
                    break;
            }

            return new MainController();
        }
    }
}
