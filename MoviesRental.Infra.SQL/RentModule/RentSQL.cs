﻿using MoviesRental.Domain.RentModule;
using System.Data;

namespace MoviesRental.Infra.SQL.RentModule
{
    public class RentSQL : RentRepository
    {
        public string SqlInsert = @"INSERT INTO RentDB
                    (
                        [EmployeeName],
                        [MoviesQuantity],
                        [MovieName],
                        [ClientName],
                        [RentalDate],
                        [ReturnDate],
                        [DayValue],
                        [MovieValue],
                        [TotalPrice],
                        [StatusImage],
                        [Status]
                    )
                    VALUES
                    (
                        @EmployeeName,
                        @MoviesQuantity,
                        @MovieName,
                        @ClientName,
                        @RentalDate,
                        @ReturnDate,
                        @DayValue,
                        @MovieValue,
                        @TotalPrice,
                        @StatusImage,
                        @Status
                    )";

        public string SqlSelect = @"SELECT * FROM RentDB";

        public string SqlDelete = @"DELETE FROM RentDB WHERE ID = @Id";

        public string SqlEdit = @"UPDATE RentDB
                    SET
                        [EmployeeName] = @EmployeeName,
                        [MoviesQuantity] = @MoviesQuantity,
                        [MovieName] = @MovieName,
                        [ClientName]= @ClientName,
                        [RentalDate] = @RentalDate,
                        [ReturnDate] = @ReturnDate,
                        [DayValue] = @DayValue,
                        [MovieValue] = @MovieValue,
                        [TotalPrice] = @TotalPrice,
                        [StatusImage] = @StatusImage,
                        [Status] = @Status
                    WHERE 
                        ID = @ID";

        public string SqlSelectId = @"SELECT
                        [Id],
                        [EmployeeName],
                        [MoviesQuantity],
                        [MovieName],
                        [ClientName],
                        [RentalDate],
                        [ReturnDate],
                        [DayValue],
                        [MovieValue],
                        [TotalPrice],
                        [StatusImage],
                        [Status]
	                FROM
                        RentDB
                    WHERE 
                        Id = @ID";

        public string SqlSelectAll =
        @"SELECT
                        [Id],
                        [EmployeeName],
                        [MoviesQuantity],
                        [MovieName],
                        [ClientName],
                        [RentalDate],
                        [ReturnDate],
                        [DayValue],
                        [MovieValue],
                        [TotalPrice],
                        [StatusImage],
                        [Status]
          
                        FROM RentDB";

        public string SqlSelectByStatus = @"SELECT
                        [Id],
                        [EmployeeName],
                        [MoviesQuantity],
                        [MovieName],
                        [ClientName],
                        [RentalDate],
                        [ReturnDate],
                        [DayValue],
                        [MovieValue],
                        [TotalPrice],
                        [StatusImage],
                        [Status]
	                FROM
                        RentDB
                    WHERE 
                        STATUS = @STATUS";

        public bool InsertNew(Rent rent)
        {
            try
            {
                DataBaseController.DataBase(SqlInsert, GetParametersRent(rent));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }  
        }

        private Dictionary<string, object> GetParametersRent(Rent rent)
        {
            var parameters = new Dictionary<string, object>();

            parameters.Add("ID", rent.Id);
            parameters.Add("EMPLOYEENAME", rent.EmployeeName);
            parameters.Add("MOVIESQUANTITY", rent.MoviesQuantity);
            parameters.Add("MOVIENAME", rent.MovieName);
            parameters.Add("CLIENTNAME", rent.ClientName);
            parameters.Add("RENTALDATE", rent.RentalDate);
            parameters.Add("RETURNDATE", rent.ReturnDate);
            parameters.Add("DAYVALUE", rent.DayValue);
            parameters.Add("MOVIEVALUE", rent.MovieValue);
            parameters.Add("TOTALPRICE", rent.TotalPrice);
            parameters.Add("STATUSIMAGE", rent.StatusImage);
            parameters.Add("STATUS", rent.Status);

            return parameters;
        }

        public bool Delete(int id)
        {
            try
            {
                DataBaseController.DataBase(SqlDelete, AddParameters("ID", id));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }     
        }

        private Dictionary<string, object> AddParameters(string v, int id)
        {
            return new Dictionary<string, object>() { { v, id } };
        }

        private Dictionary<string, object> AddParametersByStatusImage(string v, string status)
        {
            return new Dictionary<string, object>() { { v, status } };
        }

        public bool Edit(int id, Rent rent)
        {
            try
            {
                DataBaseController.DataBase(SqlEdit, GetParametersRent(rent));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }     
        }

        public List<Rent> SelectAll()
        {
            return DataBaseController.GetAll(SqlSelectAll, RentConvert);
        }

        public Rent SelectById(int id)
        {
            return DataBaseController.GetId(SqlSelectId, RentConvert, AddParameters("ID", id));
        }

        public List<Rent> GetByStatus(string status)
        {
            return DataBaseController.GetAll(SqlSelectByStatus, RentConvert, AddParametersByStatusImage("Status", status));
        }

        private Rent RentConvert(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string employeeName = ((string)reader["EMPLOYEENAME"]);
            int moviesQuantity = ((int)reader["MOVIESQUANTITY"]);
            string movieName = ((string)reader["MOVIENAME"]);
            string clientName = ((string)reader["CLIENTNAME"]);
            DateTime rentalDate = ((DateTime)reader["RENTALDATE"]);
            DateTime returnDate = ((DateTime)reader["RETURNDATE"]);
            int dayValue = ((int)reader["DAYVALUE"]);
            int movieValue = ((int)reader["MOVIEVALUE"]);
            int price = ((int)reader["TOTALPRICE"]);
            Byte[] statusImagem = (Byte[])reader["STATUSIMAGE"];
            string status = ((string)reader["STATUS"]);

            Rent rent = new Rent(employeeName, moviesQuantity, movieName, clientName, rentalDate, returnDate,dayValue,movieValue, price, statusImagem, status);

            rent.Id = id;

            return rent;
        }

        public bool ExistRentWithTheName(int id, string name)
        {
            throw new NotImplementedException();
        }

        public bool Exist(int id)
        {
            throw new NotImplementedException();
        }
    }
}
