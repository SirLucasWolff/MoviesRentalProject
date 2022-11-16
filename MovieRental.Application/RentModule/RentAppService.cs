using MoviesRental.Domain.MovieModule;
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
                rentRepository.InsertNew(rent);
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
                rentRepository.Edit(id, rent);
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
                rentRepository.Delete(id);
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
                Rent rentSelected = rentRepository.SelectById(id);
                return rentSelected;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Rent? SelectRentByName(Rent rent)
        {
            try
            {
                Rent? rentSelected;

                rentSelected = rentRepository.SelectAll().Find(x => x.EmployeName == rent.EmployeName);
                rentSelected = rentRepository.SelectAll().Find(x => x.MoviesQuantity == rent.MoviesQuantity);
                rentSelected = rentRepository.SelectAll().Find(x => x.MovieName == rent.MovieName);
                rentSelected = rentRepository.SelectAll().Find(x => x.ClientName == rent.ClientName);
                rentSelected = rentRepository.SelectAll().Find(x => x.RentalDate == rent.RentalDate);
                rentSelected = rentRepository.SelectAll().Find(x => x.ReturnDate == rent.ReturnDate);
                rentSelected = rentRepository.SelectAll().Find(x => x.DayValue == rent.DayValue);
                rentSelected = rentRepository.SelectAll().Find(x => x.MovieValue == rent.MovieValue);
                rentSelected = rentRepository.SelectAll().Find(x => x.TotalPrice == rent.TotalPrice);
                rentSelected = rentRepository.SelectAll().Find(x => x.StatusImage == rent.StatusImage);
                rentSelected = rentRepository.SelectAll().Find(x => x.Status == rent.Status);

                if (rentSelected == null)
                    return null;

                bool employeeName = rentSelected.EmployeName == rent.EmployeName;
                bool moviesQuantity = rentSelected.MoviesQuantity == rent.MoviesQuantity;
                bool movieName = rentSelected.MovieName == rent.MovieName;
                bool clientName = rentSelected.ClientName == rent.ClientName;
                bool rentalDate = rentSelected.RentalDate == rent.RentalDate;
                bool returnDate = rentSelected.ReturnDate == rent.ReturnDate;
                bool dayValue = rentSelected.DayValue == rent.DayValue;
                bool movieValue = rentSelected.MovieValue == rent.MovieValue;
                bool totalPrice = rentSelected.TotalPrice == rent.TotalPrice;
                bool statusImage = rentSelected.StatusImage == rent.StatusImage;
                bool status = rentSelected.Status == rent.Status;

                if (employeeName && moviesQuantity && movieName && clientName && rentalDate && returnDate && dayValue
                    && movieValue && totalPrice && statusImage && status)
                    return null;

                if (employeeName || moviesQuantity || movieName || clientName || rentalDate || returnDate || dayValue
                    || movieValue || totalPrice || statusImage || status)
                    return rentSelected;

                return null;
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
                List<Rent> allRentSelected = rentRepository.SelectAll();
                return allRentSelected;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
