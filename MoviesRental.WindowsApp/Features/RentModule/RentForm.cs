using MovieRental.Application.ClientModule;
using MovieRental.Application.MovieModule;
using MovieRental.Application.RentModule;
using MoviesRental.Domain.ClientModule;
using MoviesRental.Domain.MovieModule;
using MoviesRental.Domain.RentModule;
using MoviesRental.WindowsApp.Shared;

namespace MoviesRental.WindowsApp.Features.RentModule
{
    public partial class RentForm : Form
    {
        MovieAppService? movieAppService = null;

        ClientAppService? clientAppService = null;

        RentAppService? rentAppService = null;

        public List<Movie> allMovies { get; set; }

        public List<Movie> moviesSelected { get; set; }

        public List<Movie> GetAllMoviesAdded { get; set; }

        public List<Rent> rents { get; set; }

        public string statusApp { get; set; }

        private bool IsAddOperation;

        public RentForm(MovieAppService movieAppService, ClientAppService clientAppService, RentAppService rentAppService, string status, string clientName, bool statusOperation)
        {
            statusApp = status;
            this.movieAppService = movieAppService;
            this.clientAppService = clientAppService;
            this.rentAppService = rentAppService;
            InitializeComponent();
            SupplyClients(clientName);

            this.allMovies = GetAllMovies();

            if (statusApp == "Devolution")
                this.moviesSelected = GetMoviesSelected();

            this.GetAllMoviesAdded = new List<Movie>();
            this.rents = new List<Rent>();

            TableMovies.ConfigGridChekered();
            TableMovies.ConfigGridOnlyRead();
            TableMovies.Columns.AddRange(GetColumns());
            IsAddOperation = statusOperation;
        }

        private List<Movie>? GetMoviesSelected()
        {
            List<string> moviesRented = BuildTheStringMoviesToList();

            List<Movie> movies = movieAppService.SelectAllMovies();

            List<Movie> getMovies = new List<Movie>();

            foreach (var itemRented in moviesRented)
            {
                foreach (var itemMovie in movies)
                {
                    if (itemRented == itemMovie.Name)
                        getMovies.Add(itemMovie);
                }
            }

            return getMovies;
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

        public void NewRentScreen()
        {
            FineText.Visible = false;
            FineResultText.Visible = false;
            FineValueSymbol.Visible = false;
            FormText.Text = "Rent form";
            FineDatePicker.Visible = false;
        }

        public void DevolutionScreen()
        {
            List<Rent>? rent = GetCurrentRent();

            string rateDays = null;

            string moviesQuantity = null;

            foreach (var item in rent)
            {
                moviesQuantity = item.MoviesQuantity.ToString();
                rateDays = item.DayValue.ToString();
            }

            AddButton.Visible = false;
            TableMovies.Enabled = false;
            SearchButton.Enabled = false;
            MovieSelector.Enabled = false;
            FineResultText.Visible = true;
            FineText.Visible = true;
            FineValueSymbol.Visible = true;
            FormText.Text = "Devolution form";
            RateDays.Text = rateDays;
            MoviesQuantity.Text = moviesQuantity;
            ReturnDatePicker.Text = DateTime.Now.ToString();
            CalculateTotalValue();
            DaysValue.Text = DateValue().ToString();
            TotalValue.Text = GetTotalValue(rent);
            ClientSelector.Enabled = false;
            RentalDatePicker.Enabled = false;
            ReturnDatePicker.Enabled = false;
            FineResultText.Text = GetFineResult(rent);
            FineDatePicker.Visible = true;
        }

        private string GetFineResult(List<Rent> rent)
        {
            DateTime getReturnDate = new DateTime();

            foreach (var item in rent)
                getReturnDate = item.ReturnDate;

            int date = ((TimeSpan)(DateTime.Now - getReturnDate)).Days;

            foreach (var item in rent)
            {
                if (item.Status == "Pending")
                {
                    FineDatePicker.Text = item.ReturnDate.ToString();
                    return date.ToString();
                }
            }

            return "0";
        }

        private string GetTotalValue(List<Rent> rent)
        {
            int? getMovies = null;

            foreach (var item in rent)
            {
                getMovies = item.MoviesQuantity;
            }

            string getFineResult = GetFineResult(rent);

            int convertFineResult = Convert.ToInt32(getFineResult);

            int getDays = DateValue();

            int? result = getMovies + getDays + convertFineResult;

            return result.ToString();
        }

        public List<Rent>? GetCurrentRent()
        {
            List<Rent> list = rentAppService.SelectAllRents();

            foreach (var item in list)
            {
                if (item.ClientName == ClientSelector.Text)
                {
                    List<Rent> getListRight = new List<Rent>();
                    getListRight.Add(item);
                    return getListRight;
                }
            }

            return null;
        }

        public Image GetImage()
        {
            var filePath = @"D:/Movies Rental Project/Status images/Green Status.PNG";
            FileInfo fi = new FileInfo(filePath);
            Image tempImage = Image.FromFile(fi.FullName);
            return tempImage;
        }

        private List<Movie> GetMoviesByName()
        {
            string getName = MovieSelector.Text;

            string here = $"%{getName}%";

            List<Movie> movie = movieAppService.SelectMovieReference(here);

            return movie;
        }

        private List<Movie>? GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();

            List<Movie> movies = movieAppService.SelectAllMovies();

            foreach (Movie movie in movies)
            {
                if (movie.Availability == true)
                    allMovies.Add(movie);
            }

            return allMovies;
        }

        private List<string> BuildTheStringMoviesToList()
        {
            rents = rentAppService.SelectAllRents();

            char[] delimeters = new char[] { ',' };

            List<string> movies = new List<string>();

            foreach (var item in rents)
            {
                if (item.ClientName == ClientSelector.Text)
                {
                    string[] moviesName = item.MovieName.Split(delimeters);

                    foreach (var a in item.MovieName.Split(delimeters))
                    {
                        if (a != "")
                            movies.Add(a);
                    }

                    return movies;
                }
            }

            return null;
        }

        public DataGridViewColumn[] GetColumns()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Movies list" }
            };

            return colunas;
        }

        private void SupplyClients(string clientName)
        {
            ClientSelector.Items.Clear();

            ClientSelector.Text = "Select one";

            List<Client> clients = clientAppService.SelectAllClients();

            foreach (var item in clients)
            {
                ClientSelector.Items.Add(item.ClientName);
            }

            if (clientName != null)
                ClientSelector.Text = clientName;
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void ChangeMovieStatus()
        {
            foreach (var item in moviesSelected)
            {
                Movie movieToEditTheAvailabilityStatus = item;

                movieToEditTheAvailabilityStatus.Availability = true;

                movieToEditTheAvailabilityStatus.AvailabilityMessage = "Available";

                movieAppService.EditMovie(item.Id, movieToEditTheAvailabilityStatus);
            }
        }

        private string GetMoviesName()
        {
            string movieName = "";

            foreach (var item in GetAllMoviesAdded)
            {
                Movie movieToEditTheAvailabilityStatus = item;

                movieToEditTheAvailabilityStatus.Availability = false;

                movieToEditTheAvailabilityStatus.AvailabilityMessage = "Rented";

                movieAppService.EditMovie(item.Id, movieToEditTheAvailabilityStatus);

                movieName += item.Name;
                movieName += ",";
            }

            return movieName;
        }

        private void RentForm_Load(object sender, EventArgs e)
        {
            if (IsAddOperation == true)
            {
                RentalDatePicker.Text = string.Empty;
                ReturnDatePicker.Text = string.Empty;
            }

            if (statusApp == "Devolution")
                TableMovies.DataSource = moviesSelected;
            else
                TableMovies.DataSource = allMovies;
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
            if (statusApp == "Devolution")
            {
                ChangeMovieStatus();

                return;
            }

            string employee = CurrentAccount.EmployeeName;

            int movieQuantity = 0;

            if (!String.IsNullOrEmpty(MoviesQuantity.Text))
                movieQuantity = Convert.ToInt32(MoviesQuantity.Text);

            string movieName = GetMoviesName();

            string client = ClientSelector.Text;

            DateTime rentaDate = DateTime.MinValue;

            if (RentalDatePicker.Text != "  /")
                rentaDate = Convert.ToDateTime(RentalDatePicker.Text);

            DateTime returnDate = DateTime.MinValue;

            if (ReturnDatePicker.Text != "  /")
                returnDate = Convert.ToDateTime(ReturnDatePicker.Text);

            int dayValue = DateValue();

            string getMovieValue = CalculateMoviesValue();

            int movieValue = Convert.ToInt32(getMovieValue);

            int totalValue = dayValue + movieValue;

            Byte[] statusImage = ConvertImageToBinary(GetImage());

            string status = "Active";

            Rent = new Rent(employee, movieQuantity, movieName, client, rentaDate, returnDate, dayValue, movieValue, totalValue, statusImage, status);
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            string name = TableMovies.SelectId<string>();

            if (name != null)
            {
                List<Movie> movies = movieAppService.SelectListByMovieName(name);

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
