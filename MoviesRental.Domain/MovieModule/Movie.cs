using MoviesRental.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.MovieModule
{
    public class Movie: BaseEntity<int>
    {
        public string? Name { get; set; }

        public string? Category { get; set; }

        public string? Classification { get; set; }

        public bool? Availability { get; set; }

        public string? AvailabilityMessage { get; set; }

        public DateTime? ReleaseDate { get; set; } 

        public Movie(string? name, string category, string classification, DateTime releaseDate, bool availability, string? availabilityMessage)
        {
            Name = name;
            Category = category;
            Classification = classification;
            ReleaseDate = releaseDate;
            Availability = availability;
            AvailabilityMessage = availabilityMessage;
        }

        public Movie() { }

        public string Validation()
        {
            string ValidationResult = "";

            if (string.IsNullOrWhiteSpace(Name))
                ValidationResult = "The movie name cannot be null";

            if (string.IsNullOrWhiteSpace(Category))
                ValidationResult = "The category cannot be null";

            if (string.IsNullOrWhiteSpace(Classification))
                ValidationResult = "The classification cannot be null";

            if (ValidationResult == "")
                ValidationResult = "Is_Valid";

            return ValidationResult;
        }
    }
}
