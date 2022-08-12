using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.ClientModule
{
    public class Client
    {
        public int Id { get; set; }

        public string? ClientName { get; set; }

        public int Telephone { get; set; }

        public string? Address { get; set; }
        
        public DateTime? BornDate { get; set; }

        public Client(int id,string? clientName, int telephone, string address, DateTime bornDate)
        {
            this.Id = id;
            ClientName = clientName;
            Telephone = telephone;
            Address = address;
            BornDate = bornDate;
        }

        public Client() { }

        public string Validation()
        {
            string ValidationResult = "";

            if (string.IsNullOrWhiteSpace(ClientName))
                ValidationResult = "The client name cannot be null";

            if (Telephone == 0)
                ValidationResult = "The telephone cannot be null";

            if (string.IsNullOrWhiteSpace(Address))
                ValidationResult = "The address cannot be null";

            if (BornDate == null)
                ValidationResult = "The age date cannot be null";

            if (ValidationResult == "")
                ValidationResult = "Is_Valid";

            return ValidationResult;
        }
    }
}
