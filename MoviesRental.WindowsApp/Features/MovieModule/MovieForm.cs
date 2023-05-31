using MoviesRental.Domain.MovieModule;

namespace MoviesRental.WindowsApp.Features.MovieModule
{
    public partial class MovieForm : Form
    {
        private bool IsAddOperation;
        public MovieForm(bool statusOperation)
        {
            InitializeComponent();
            SupplySelectors();
            TextBoxCategories.Enabled = false;
            IsAddOperation = statusOperation;
        }

        private Movie movie;

        public Movie Movie
        {
            get { return movie; }
            set
            {
                movie = value;

                TextMovieName.Text = movie.Name;
                TextBoxCategories.Text = movie.Category;
                ClassificationSelector.Text = movie.Classification;
                ReleaseDatePicker.Text = movie.ReleaseDate.ToString();
            }
        }

        public string GetAvailabilityMessage(bool availability)
        {
            if (availability)
                return "Available";
            else
                return "Rented";
        }

        #region CodeMethods

        private void SupplySelectors()
        {
            CategorySelector.Text = "Select one";
            CategorySelector.Items.Add("Adventure");
            CategorySelector.Items.Add("Animation");
            CategorySelector.Items.Add("Action");
            CategorySelector.Items.Add("Comedy");
            CategorySelector.Items.Add("Crime");
            CategorySelector.Items.Add("Documentary");
            CategorySelector.Items.Add("Drama");
            CategorySelector.Items.Add("Fantasy");
            CategorySelector.Items.Add("History");
            CategorySelector.Items.Add("Horror");
            CategorySelector.Items.Add("Musical");
            CategorySelector.Items.Add("Mistery");
            CategorySelector.Items.Add("Mistery");
            CategorySelector.Items.Add("Romance");
            CategorySelector.Items.Add("Real facts");
            CategorySelector.Items.Add("Sci-Fi");
            CategorySelector.Items.Add("War");

            ClassificationSelector.Text = "Select one";
            ClassificationSelector.Items.Add("L");
            ClassificationSelector.Items.Add("10");
            ClassificationSelector.Items.Add("14");
            ClassificationSelector.Items.Add("18");
        }

        #endregion

        #region Events

        private void MovieForm_Load(object sender, EventArgs e)
        {
            if (IsAddOperation == true)
            {
                TextMovieName.Text = string.Empty;
                TextBoxCategories.Text = string.Empty;
                ClassificationSelector.Text = string.Empty;
                ReleaseDatePicker.Text = string.Empty;
            }

            if (TextBoxCategories.TextLength != 0 && TextBoxCategories.Text.EndsWith(",") == false)
            {
                TextBoxCategories.Text += ",";
            }
        }

        private void CategorySelector_SelectedValueChanged(object sender, EventArgs e)
        {
            TextBoxCategories.Text += $"{CategorySelector.Text},";
        }

        #endregion

        #region ButtonsClick

        private void EnterButtonMovie_Click(object sender, EventArgs e)
        {
            string name = TextMovieName.Text;

            string category = TextBoxCategories.Text;

            string classification = ClassificationSelector.Text;  //.Remove(ClassificationSelector.Text.Length - 1);

            DateTime releaseDate = DateTime.MinValue;

            if (ReleaseDatePicker.Text != "  /  /")
                releaseDate = Convert.ToDateTime(ReleaseDatePicker.Text);

            bool availability = true;

            string availabiltyMessage = GetAvailabilityMessage(availability);

            Movie = new Movie(name, category, classification, releaseDate, availability, availabiltyMessage);
        }

        private void ClearCategoriesButton_Click(object sender, EventArgs e)
        {
            TextBoxCategories.Clear();
        }




        #endregion


    }
}
