using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.EmployeeModule
{
    public class Employee
    {
        public int Id { get; set; }

        public string? Email { get; set; }

        public string? Name { get; set; }

        public string? Password { get; set; }

        public string? AccessKey { get; set; }

        public Employee (int id, string? email, string? name, string? password, string? accessKey)
        {
            this.Id = id;
            Email = email;
            Name = name;
            Password = password;
            AccessKey = accessKey;
        }

        public Employee()
        {
        }

        public string Validation()
        {
            string ValidationResult = "";

            if (string.IsNullOrEmpty(Email))
                ValidationResult = "The email cannot be null";

            if (string.IsNullOrWhiteSpace(Name))
                ValidationResult = "The name cannot be null";

            if (string.IsNullOrWhiteSpace(Password))
                ValidationResult = "The password cannot be null";

            if (ValidationResult == "")
                ValidationResult = "Is_Valid";

            return ValidationResult;
        }
    }
}
