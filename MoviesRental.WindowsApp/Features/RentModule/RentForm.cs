using MovieRental.Application.ClientModule;
using MovieRental.Application.EmployeModule;
using MovieRental.Application.MovieModule;
using MovieRental.Application.RentModule;
using MoviesRental.Domain.ClientModule;
using MoviesRental.Domain.EmployeeModule;
using MoviesRental.Domain.MovieModule;
using MoviesRental.Domain.RentModule;
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

namespace MoviesRental.WindowsApp.Features.RentModule
{
    public partial class RentForm : Form
    {
        EmployeAppService? employeAppService = null;

        MovieAppService? movieAppService = null;

        ClientAppService? clientAppService = null;

        public List<Movie> Movies { get; set; }

        public List<Movie> GetAllMoviesAdded { get; set; }

        public RentForm(EmployeAppService employeAppService, MovieAppService movieAppService, ClientAppService clientAppService)
        {
            this.employeAppService = employeAppService;
            this.movieAppService = movieAppService;
            this.clientAppService = clientAppService;
            InitializeComponent();
            SupplyClients();
            TableMovies.ConfigGridChekered();
            TableMovies.ConfigGridOnlyRead();
            TableMovies.Columns.AddRange(GetColumns());
            this.Movies = GetMovies();
            this.GetAllMoviesAdded = new List<Movie>();
        }

        private Rent rent;

        public Rent Rent
        {
            get { return rent; }
            set
            {
                rent = value;

                MoviesValue.Text = rent.MoviesQuantity.ToString();

                ClientSelector.Text = rent.ClientName;

                RentalDatePicker.Text = rent.RentalDate.ToString();

                ReturnDatePicker.Text = rent.ReturnDate.ToString();

                DaysValue.Text = rent.DayValue.ToString();

                MoviesValue.Text = rent.MovieValue.ToString();

                TotalValue.Text = rent.TotalPrice.ToString();
            }
        }

        #region CodeMethods

        public Image GetImage()
        {
            var filePath = @"D:/Movies Rental Project/Status images/Green Status.PNG";
            FileInfo fi = new FileInfo(filePath);
            Image tempImage = Image.FromFile(fi.FullName);
            return tempImage;
        }

        public void DesableTableMovies()
        {
            TableMovies.Enabled = false;
            AddButton.Enabled = false;
            SearchButton.Enabled = false;
            MovieSelector.Enabled = false;
        }

        private List<Movie> GetMoviesByName()
        {
            string getName = MovieSelector.Text;

            string here = $"%{getName}%";

            List<Movie> movie = movieAppService.SelectMovieReference(here);

            return movie;
        }

        private List<Movie>? GetMovies()
        {
            List<Movie> movies = movieAppService.SelectAllMovies();

            return movies;
        }

        public DataGridViewColumn[] GetColumns()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Movies list" }
            };

            return colunas;
        }

        private void SupplyClients()
        {
            ClientSelector.Items.Clear();

            ClientSelector.Text = "Select one";

            List<Client> clients = clientAppService.SelectAllClients();

            foreach (var item in clients)
            {
                ClientSelector.Items.Add(item.ClientName);
            }
            if (clients.Count > 0)
                ClientSelector.SelectedIndex = 0;
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private string GetMoviesName()
        {
            string movieName = "";

            foreach (var item in GetAllMoviesAdded)
            {
                movieName += item.Name;
                movieName += ",";
            }

            return movieName;
        }

        private void RentForm_Load(object sender, EventArgs e)
        {
            var movies = Movies;

            TableMovies.DataSource = movies;
        }

        private void CalculateTotalValue()
        {
            int getMoviesValue = Convert.ToInt32(MoviesValue.Text);

            int getDaysValue = Convert.ToInt32(DaysValue.Text);

            int getTotalValue = getMoviesValue + getDaysValue;

            TotalValue.Text = getTotalValue.ToString();

        }

        private string CalculateMoviesValue()
        {
            DateTime getDate = new DateTime(2021, 01, 01);

            int result = 0;

            foreach (var item in GetAllMoviesAdded)
            {
                if (item.ReleaseDate < getDate)
                    result++;

                if (item.ReleaseDate > getDate)
                    result += 2;
            }

            return result.ToString();
        }

        private int DateValue()
        {
            try
            {
                DateTime rentalDate = Convert.ToDateTime(RentalDatePicker.Text);

                DateTime returnDate = Convert.ToDateTime(ReturnDatePicker.Text);

                int date = ((TimeSpan)(returnDate - rentalDate)).Days;

                RateDays.Text = date.ToString();

                DaysValue.Text = date.ToString();

                return date;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        #endregion

        #region LeaveEvents

        private void RentalDatePicker_Leave(object sender, EventArgs e)
        {
            DateValue();

            CalculateTotalValue();
        }

        private void ReturnDatePicker_Leave(object sender, EventArgs e)
        {
            DateValue();

            CalculateTotalValue();
        }

        #endregion

        #region ButtonsClick

        private void EnterButtonRent_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int id = random.Next();

            string employee = CurrentAccount.EmployeeName;

            int movieQuantity = Convert.ToInt32(MoviesValue.Text);

            string movieName = GetMoviesName();

            string client = ClientSelector.Text;

            DateTime rentaDate = Convert.ToDateTime(RentalDatePicker.Text);

            DateTime returnDate = Convert.ToDateTime(ReturnDatePicker.Text);

            int dayValue = DateValue();

            string getMovieValue = CalculateMoviesValue();

            int movieValue = Convert.ToInt32(getMovieValue);

            int totalValue = dayValue + movieValue;

            Byte[] statusImage = ConvertImageToBinary(GetImage());

            string status = "Active";

            Rent = new Rent(id, employee, movieQuantity, movieName, client, rentaDate, returnDate, dayValue, movieValue, totalValue, statusImage, status);
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            string name = TableMovies.SelectId<string>();

            if (name != null)
            {
                List<Movie> movies = movieAppService.SelectMovieName(name);

                foreach (var item in movies)
                {
                    GetAllMoviesAdded.Add(item);

                    MoviesQuantity.Text = GetAllMoviesAdded.Count().ToString();

                    MoviesValue.Text = CalculateMoviesValue();

                    CalculateTotalValue();
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            TableMovies.DataSource = GetMoviesByName();
        }

        #endregion
    }
}
