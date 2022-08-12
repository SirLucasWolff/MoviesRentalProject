using MoviesRental.Domain.MovieModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MoviesRental.Domain.RentModule
{
    public class Rent
    {
        public int Id { get; set; }

        public string? EmployeName { get; set; }

        public int? MoviesQuantity { get; set; }

        public string MovieName { get; set; }

        public string? ClientName { get; set; }

        public DateTime RentalDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public int DayValue { get; set; }

        public int MovieValue { get; set; }

        public int? TotalPrice { get; set; }

        public Byte[] StatusImage { get; set; } 

        public string? Status { get; set; }

        public Rent (int id, string? employeName, int? moviesQuantity, string movieName, string? clientName, DateTime rentalDate, DateTime returnDate, int dayValue, int movieValue, int? totalPrice, Byte[] statusImage, string? status)
        {
            Id = id;
            EmployeName = employeName;
            MoviesQuantity = moviesQuantity;
            ClientName = clientName;
            MovieName = movieName;
            RentalDate = rentalDate;
            ReturnDate = returnDate;
            DayValue = dayValue;
            MovieValue = movieValue;
            TotalPrice = totalPrice;
            StatusImage = statusImage;
            Status = status;
        }

        public string Validation()
        {
            string ValidationResult = "";

            if (string.IsNullOrEmpty(EmployeName))
                ValidationResult = "The employee name cannot be null";

            if (MoviesQuantity == 0)
                ValidationResult = "The movies quantity cannot be null";

            if (MovieName == null)
                ValidationResult = "The movie name cannot be null";

            if (string.IsNullOrEmpty(ClientName))
                ValidationResult = "The client name cannot be null";

            if (RentalDate == null)
                ValidationResult = "The rental date cannot be null";

            if (ReturnDate == null)
                ValidationResult = "The return date cannot be null";

            if (DayValue == 0)
                ValidationResult = "The day value cannot be null";

            if (MovieValue == 0)
                ValidationResult = "The movie value cannot be null";

            if (TotalPrice == 0)
                ValidationResult = "The total price cannot be null";

            if (ValidationResult == "")
                ValidationResult = "Is_Valid";

            return ValidationResult;
        }

        public Rent() { }
    }
}
