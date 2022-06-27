using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.EmployeModule
{
    public class Employe
    {
        public int id { get; set; }

        public string? Name { get; set; }

        public string? Password { get; set; }

        public Employe (int id, string? name, string? password)
        {
            this.id = id;
            Name = name;
            Password = password;
        }

        public Employe()
        {
        }
    }
}
