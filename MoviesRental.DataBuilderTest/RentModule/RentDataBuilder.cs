using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoviesRental.Domain.RentModule;

namespace MoviesRental.DataBuilderTest.RentModule
{
    [TestClass]
    public class RentDataBuilder
    {
        private Rent rents;

        public Rent Build()
        {
            return rents;
        }

        public RentDataBuilder()
        {
            rents = new Rent();
        }

        public RentDataBuilder WithClientName(string name)
        {
            rents.ClientName = name;
            return this;
        }

        public RentDataBuilder WithEmployeeName(string name)
        {
            rents.EmployeName = name;
            return this;
        }

        public RentDataBuilder WithMoviesQuantity(int quantity)
        {
            rents.MoviesQuantity = quantity;
            return this;
        }

        public RentDataBuilder WithMovieName(string name)
        {
            rents.MovieName = name;
            return this;
        }

        public RentDataBuilder WithRentalDate(DateTime date)
        {
            rents.RentalDate = date;
            return this;
        }

        public RentDataBuilder WithReturnDate(DateTime date)
        {
            rents.ReturnDate = date;
            return this;
        }

        public RentDataBuilder WithDayValue(int value)
        {
            rents.DayValue = value;
            return this;
        }

        public RentDataBuilder WithMovieValue(int value)
        {
            rents.MovieValue = value;
            return this;
        }

        public RentDataBuilder WithTotalPrice(int price)
        {
            rents.TotalPrice = price;
            return this;
        }

        public RentDataBuilder WithStatusImage(Byte[] image)
        {
            rents.StatusImage = image;
            return this;
        }

        public RentDataBuilder WithStatus(string status)
        {
            rents.Status = status;
            return this;
        }

        public Rent GenerateCompleteRent()
        {
            return this.WithEmployeeName("testName")
                .WithMoviesQuantity(2)
                .WithMovieValue(2)
                .WithDayValue(2)
                .WithMovieName("testName")
                .WithClientName("testName")
                .WithRentalDate(DateTime.Now)
                .WithReturnDate(DateTime.Now)
                .WithStatusImage(null)
                .WithTotalPrice(2)
                .WithStatus("testName").Build();
        }
    }
}