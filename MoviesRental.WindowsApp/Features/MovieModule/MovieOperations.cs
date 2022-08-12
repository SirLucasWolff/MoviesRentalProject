using MovieRental.Application.MovieModule;
using MoviesRental.Domain.MovieModule;
using MoviesRental.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.WindowsApp.Features.MovieModule
{
    public class MovieOperations : IRegister
    {
        private MovieAppService appService = null;
        private MovieTable movieTable = null;

        public MovieOperations (MovieAppService appService)
        {
            this.appService = appService;
            movieTable = new MovieTable(appService);
        }

        public void DeleteRegister()
        {
            int id = movieTable.GetIdSelected();

            if (id == 0)
            {
                MessageBox.Show("Select a movie to delete", "Movie deleting",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Movie movieSelected = appService.SelectMovieId(id);

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

            if (id == 0)
            {
                MessageBox.Show("Select a movie to edit", "Movie editing",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Movie movieSelected = appService.SelectMovieId(id);

            MovieForm form = new MovieForm();
            form.Movie = movieSelected;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
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
    }
}
