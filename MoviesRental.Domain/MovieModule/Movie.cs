using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.MovieModule
{
    public class Movie
    {
        public int id { get; set; }

        public string? Name { get; set; }

        public Movie(int id, string? name)
        {
            this.id = id;
            Name = name;
        }

        public Movie() { }
    }
}
