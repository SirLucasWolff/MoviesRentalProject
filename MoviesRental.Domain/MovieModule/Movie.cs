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

        public DateTime? ReleaseDate { get; set; } 

        public Movie(string? name, string category, string classification, DateTime releaseDate)
        {
            Name = name;
            Category = category;
            Classification = classification;
            ReleaseDate = releaseDate;
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
