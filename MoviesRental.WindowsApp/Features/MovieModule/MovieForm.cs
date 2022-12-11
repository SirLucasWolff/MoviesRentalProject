using MoviesRental.Domain.MovieModule;
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
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
            SupplySelectors();
            TextBoxCategories.Enabled = false;
            EnterButtonMovie.Enabled = false;
        }

        //Should build the properties using the domain class of form.

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
                return "Located";
        }

        #region CodeMethods

        private void SupplySelectors()
        {
            CategorySelector.Text = "Select one";
            CategorySelector.Items.Add("Drama");
            CategorySelector.Items.Add("Comedy");
            CategorySelector.Items.Add("Sci-Fi");
            CategorySelector.Items.Add("Action");
            CategorySelector.Items.Add("Adventure");
            CategorySelector.Items.Add("Crime");
            CategorySelector.Items.Add("Fantasy");
            CategorySelector.Items.Add("History");
            CategorySelector.Items.Add("Horror");
            CategorySelector.Items.Add("Musical");
            CategorySelector.Items.Add("Mistery");
            CategorySelector.Items.Add("Romance");
            CategorySelector.Items.Add("Mistery");
            CategorySelector.Items.Add("War");

            ClassificationSelector.Text = "Select one";
            ClassificationSelector.Items.Add("L");
            ClassificationSelector.Items.Add("10");
            ClassificationSelector.Items.Add("14");
            ClassificationSelector.Items.Add("18");
        }

        private void VerifyTextsToAbleEnterButton()
        {
            try
            {
                if (TextMovieName.Text.ToString().Length >= 1 && TextBoxCategories.Text != "Select one" && ClassificationSelector.Text != "Select one" && Convert.ToDateTime(ReleaseDatePicker.Text) < DateTime.Now)
                {
                    EnterButtonMovie.Enabled = true;
                }
                else
                {
                    EnterButtonMovie.Enabled = false;
                }
            }
            catch (Exception ex)
            { }
        }

        #endregion

        #region Events

        private void CategorySelector_SelectedValueChanged(object sender, EventArgs e)
        {
            TextBoxCategories.Text += $"{CategorySelector.Text},";
        }

        private void TextMovieName_Leave(object sender, EventArgs e)
        {
            VerifyTextsToAbleEnterButton();
        }

        private void ClassificationSelector_Leave(object sender, EventArgs e)
        {
            VerifyTextsToAbleEnterButton();
        }

        private void CategorySelector_Leave(object sender, EventArgs e)
        {
            VerifyTextsToAbleEnterButton();
        }

        private void ReleaseDatePicker_Leave(object sender, EventArgs e)
        {
            VerifyTextsToAbleEnterButton();
        }

        #endregion

        #region ButtonsClick

        private void EnterButtonMovie_Click(object sender, EventArgs e)
        {
            string name = TextMovieName.Text;

            string category = TextBoxCategories.Text;

            string classification = ClassificationSelector.Text;

            DateTime releaseDate = Convert.ToDateTime(ReleaseDatePicker.Text);

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
