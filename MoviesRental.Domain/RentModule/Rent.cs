using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.RentModule
{
    public  class Rent
    {
        public int Id { get; set; }

        public string? EmployeName { get; set; }

        public string? MovieName { get; set; }

        public string? ClientName { get; set; }

        public DateTime RentalDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public Rent (int id, string? employeName, string? movieName, string? clientName, DateTime rentalDate, DateTime returnDate)
        {
            Id = id;
            EmployeName = employeName;
            ClientName = clientName;
            MovieName = movieName;
            RentalDate = rentalDate;
            ReturnDate = returnDate;
        }

        public Rent() { }
    }
}
