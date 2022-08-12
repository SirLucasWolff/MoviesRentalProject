using MoviesRental.Domain.RentModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Application.RentModule
{
    public class RentAppService
    {
        RentRepository rentRepository;

        public RentAppService (RentRepository rentRepository)
        {
            this.rentRepository = rentRepository;
        }

        public string InsertNewRent(Rent rent)
        {
            string ValidationResult = rent.Validation();

            try
            {
                rentRepository.AddRent(rent);
            }
            catch (Exception ex)
            {
                return "The rent cannot be insert";
            }

            return ValidationResult;
        }

        public string EditRent(int id, Rent rent)
        {
            string ValidationResult = rent.Validation();

            try
            {
                rent.Id = id;
                rentRepository.EditRent(id, rent);
            }
            catch (Exception ex)
            {
                return "The rent cannot be edited";
            }

            return ValidationResult;
        }

        public bool DeleteRent(int id)
        {
            try
            {
                rentRepository.DeleteRent(id);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public Rent SelectRentId(int id)
        {
            try
            {
                Rent rentSelected = rentRepository.GetById(id);
                return rentSelected;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Rent> SelectAllRents()
        {
            try
            {
                List<Rent> allRentSelected = rentRepository.GetAll();
                return allRentSelected;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
