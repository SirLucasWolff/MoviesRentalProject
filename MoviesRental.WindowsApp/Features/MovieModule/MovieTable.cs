using MovieRental.Application.MovieModule;
using MoviesRental.Domain.MovieModule;
using MoviesRental.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesRental.WindowsApp.Features.MovieModule
{
    public partial class MovieTable : UserControl
    {
        private readonly MovieAppService movieAppService;
        public MovieTable(MovieAppService movieAppService)
        {
            InitializeComponent();
            DataGridMovie.ConfigGridChekered();
            DataGridMovie.ConfigGridOnlyRead();
            DataGridMovie.Columns.AddRange(GetColumns());
            this.movieAppService = movieAppService;

        }
        public DataGridViewColumn[] GetColumns()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Name"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Classification", HeaderText = "Classification"},

                 new DataGridViewTextBoxColumn { DataPropertyName = "AvailabilityMessage", HeaderText = "Availability"},
            };

            return colunas;
        }
        public int GetIdSelected()
        {
            return DataGridMovie.SelectId<int>();
        }

        public void UpdateRegisters()
        {
            var employees = movieAppService.SelectAllMovies();

            LoadTable(employees);
        }

        private void LoadTable(List<Movie> movies)
        {
            DataGridMovie.DataSource = movies;
        }
    }
}
