using MovieRental.Application.MovieModule;
using MoviesRental.Domain.MovieModule;
using MoviesRental.WindowsApp.Shared;

namespace MoviesRental.WindowsApp.Features.MovieModule
{
    public class MovieOperations : IRegister
    {
        private MovieAppService appService;

        private MovieTable movieTable;

        public static MovieOperations? instance;

        public static List<Movie> moviesToMigrate = new List<Movie>();

        public MovieOperations(MovieAppService appService)
        {
            instance = this;
            this.appService = appService;
            movieTable = new MovieTable(appService);
        }

        public void GetList()
        {
            List<Movie> movies = appService.SelectAllMovies();

            moviesToMigrate.AddRange(movies);
        }

        public void DeleteRegister()
        {
            int id = movieTable.GetIdSelected();

            Movie movieSelected = appService.SelectMovieId(id);

            if (id == 0)
            {
                MessageBox.Show("Select a movie to delete", "Movie deleting",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (movieSelected.Availability == false)
            {
                MessageBox.Show("The movie can't be removed because it's rented", "Movie deleting",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show($"Do you have sure about to delete: [{movieSelected.Name}] ?",
                "Movie deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (appService.DeleteMovie(id))
                {
                    movieTable.UpdateRegisters();
                    MainForm.instance.UpdateFooter($"Movie: [{movieSelected.Name}] deleted with success");
                }
                else
                {
                    MainForm.instance.UpdateFooter($"It wasn't possible to delete the movie {movieSelected.Name}");
                }
            }
        }

        public void EditRegister()
        {
            int id = movieTable.GetIdSelected();

            Movie movieSelected = appService.SelectMovieId(id);

            if (id == 0)
            {
                MessageBox.Show("Select a movie to edit", "Movie editing",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (movieSelected.Availability == false)
            {
                MessageBox.Show("The movie is rented", "Movie editing",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MovieForm form = new MovieForm();
            form.Movie = movieSelected;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                string getCategory = form.Movie.Category.Remove(form.Movie.Category.Length - 1);

                form.Movie.Category = getCategory;

                string result = appService.EditMovie(id, form.Movie);

                if (result == "Is_Valid")
                {
                    movieTable.UpdateRegisters();
                    MainForm.instance.UpdateFooter($"Movie: [{form.Movie.Name}] edited with success");
                }
                else
                {
                    MainForm.instance.UpdateFooter(result);
                }
            }
        }

        public UserControl GetTable()
        {
            movieTable.UpdateRegisters();

            return movieTable;
        }

        public UserControl GetTableFiltered(string filter)
        {
            throw new NotImplementedException();
        }

        public void InsertNewRegister()
        {
            MovieForm movieForm = new MovieForm();

            if (movieForm.ShowDialog() == DialogResult.OK)
            {
                string getCategory = movieForm.Movie.Category.Remove(movieForm.Movie.Category.Length -1);

                movieForm.Movie.Category = getCategory;

                string result = appService.InsertNewMovie(movieForm.Movie);

                if (result == "Is_Valid")
                {
                    movieTable.UpdateRegisters();
                    MainForm.instance.UpdateFooter($"Movie {movieForm.Movie.Name} inserted with success");
                }
                else
                {
                    MainForm.instance.UpdateFooter(result);
                }
            }
        }

        public void MigrateRegister()
        {
            foreach (Movie movieToMigrate in moviesToMigrate)
            {
                Movie? movieToEdit = appService.SelectMovieByName(movieToMigrate);

                movieToMigrate.Id = 0;

                string? getResult = ValidateMigrate(movieToMigrate);

                if (getResult == "InsertingWhileMigrate")
                    appService.InsertNewMovie(movieToMigrate);

                if (getResult == "EditingWhileMigrate" && movieToEdit != null)
                    appService.EditMovie(movieToEdit.Id, movieToMigrate);
            }
        }

        private string? ValidateMigrate(Movie movie)
        {
            List<Movie> allMovies = appService.SelectAllMovies();

            if (allMovies.Count == 0)
                return "InsertingWhileMigrate";

            bool name = allMovies.Exists(d => d.Name == movie.Name);
            bool category = allMovies.Exists(d => d.Category == movie.Category);
            bool classification = allMovies.Exists(d => d.Classification == movie.Classification);
            bool releaseDate = allMovies.Exists(d => d.ReleaseDate == movie.ReleaseDate);

            if (!name && !category && !classification && !releaseDate)
                return "InsertingWhileMigrate";

            if (name || category || classification || releaseDate)
                return "EditingWhileMigrate";

            return null;
        }
    }
}
