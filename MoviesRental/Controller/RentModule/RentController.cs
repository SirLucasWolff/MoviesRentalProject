using MoviesRental.DataBase;
using MoviesRental.Domain.RentModule;
using RentalMovies.Controller.ClientModule;
using RentalMovies.Controller.EmployeeModule;
using RentalMovies.Controller.MovieModule;
using RentalMovies.Screen.RentModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Controller.RentModule
{
    public class RentController : RentRepository
    {
        RentScreen rentScreen = new RentScreen();

        ClientController clientController = new ClientController();

        MovieController movieController = new MovieController();

        EmployeeController employeController = new EmployeeController();

        public string SqlInsert = @"INSERT INTO RENTDB
                    (
                        [EmployeName],
                        [MovieName],
                        [ClientName],
                        [RentalDate],
                        [ReturnDate]
                    )
                    VALUES
                    (
                        @EmployeName,
                        @MovieName,
                        @ClientName,
                        @RentalDate,
                        @ReturnDate
                    )";

        public string SqlSelect = @"SELECT * FROM RENTDB";

        public string SqlDelete = @"DELETE FROM RENTDB WHERE ID = @Id";

        public string SqlEdit = @"UPDATE RENTDB
                    SET
                        [EmployeName] = @EmployeName,
                        [MovieName] = @MovieName,
                        [ClientName] = @ClientName,
                        [RentalDate] = @RentalDate,
                        [ReturnDate] = @ReturnDate
                    WHERE 
                        ID = @ID";

        public string SqlSelectId = @"SELECT
                        [ID],
                        [EmployeName],
                        [MovieName],
                        [ClientName],
                        [RentalDate],
                        [ReturnDate]
	                FROM
                        RENTDB
                    WHERE 
                        ID = @ID";

        public void AddRent(Rent rent)
        {
            Console.Clear();

            Random rnd = new Random();
            rent.Id = rnd.Next();

            employeController.ShowEmployees();

            Console.WriteLine("Insert the employe name:");
            rent.EmployeName = Console.ReadLine();

            if (employeController.Validation(rent.EmployeName) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Don't exist in registers");
                Console.ResetColor();
                Console.WriteLine("1 - Try again");
                Console.WriteLine("2 - Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddRent(rent);
                        return;
                    case 2:
                        return;
                }

                return;
            }

            Console.Clear();

            movieController.ShowMovies();

            Console.WriteLine("Insert the movie name:");
            rent.MovieName = Console.ReadLine();

            if (movieController.Validation(rent.MovieName) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Don't exist in registers");
                Console.ResetColor();
                Console.WriteLine("1 - Try again");
                Console.WriteLine("2 - Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddRent(rent);
                        return;
                    case 2:
                        return;
                }

                return;
            }

            Console.Clear();

            clientController.ShowClients();

            Console.WriteLine("Insert the client name:");
            rent.ClientName = Console.ReadLine();

            if (clientController.Validation(rent.ClientName) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Don't exist in registers");
                Console.ResetColor();
                Console.WriteLine("1 - Try again");
                Console.WriteLine("2 - Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddRent(rent);
                        return;
                    case 2:
                        return;
                }

                return;
            }

            Console.Clear();

            Console.WriteLine("Insert the rental date:");
            rent.RentalDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Insert the return date:");
            rent.ReturnDate = Convert.ToDateTime(Console.ReadLine());

            DataBaseController.DataBase(SqlInsert, GetParametersRents(rent));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Rent created with success");
            Console.ReadLine();
            Console.ResetColor();
        }

        public void DeleteRent(int id)
        {
            Console.Clear();

            ShowRents();

            Console.WriteLine("Select the rent id to delete:");
            id = Convert.ToInt32(Console.ReadLine());

            DataBaseController.DataBase(SqlDelete, AddParameters("ID", id));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Rent deleted with success");
            Console.ReadLine();
            Console.ResetColor();
        }

        private Dictionary<string, object> AddParameters(string v, int id)
        {
            return new Dictionary<string, object>() { { v, id } };
        }

        private Dictionary<string, object> GetParametersRents(Rent rent)
        {
            var parameters = new Dictionary<string, object>();

            parameters.Add("ID", rent.Id);
            parameters.Add("EmployeName", rent.EmployeName);
            parameters.Add("MovieName", rent.MovieName);
            parameters.Add("ClientName", rent.ClientName);
            parameters.Add("RentalDate", rent.RentalDate);
            parameters.Add("ReturnDate", rent.ReturnDate);

            return parameters;
        }

        public void ShowRents()
        {
            rentScreen.ShowRents(SqlSelect);
        }

        public void EditRent(int id,Rent rent)
        {
            Console.Clear();

            ShowRents();

            Console.WriteLine("Select the rent id to edit:");
            id = Convert.ToInt32(Console.ReadLine());

            rent = GetById(id);

            Console.WriteLine("1 - Edit the employe name");
            Console.WriteLine("2 - Edit the movie name");
            Console.WriteLine("3 - Edit the client name");
            Console.WriteLine("4 - Edit the return date");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Insert the new employe name");
                    rent.EmployeName = Console.ReadLine();
                    if (employeController.Validation(rent.EmployeName) == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Don't exist in registers");
                        Console.ResetColor();
                        Console.WriteLine("1 - Try again");
                        Console.WriteLine("2 - Exit");
                        int employeOption = Convert.ToInt32(Console.ReadLine());

                        switch (employeOption)
                        {
                            case 1:
                                EditRent(rent.Id,rent);
                                return;
                            case 2:
                                return;
                        }

                        return;
                    }
                    break;
                case 2:
                    Console.WriteLine("Insert the new movie name");
                    rent.MovieName = Console.ReadLine();
                    if (movieController.Validation(rent.MovieName) == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Don't exist in registers");
                        Console.ResetColor();
                        Console.WriteLine("1 - Try again");
                        Console.WriteLine("2 - Exit");
                        int movieOprion = Convert.ToInt32(Console.ReadLine());

                        switch (movieOprion)
                        {
                            case 1:
                                EditRent(rent.Id, rent);
                                return;
                            case 2:
                                return;
                        }

                        return;
                    }
                    break;
                case 3:
                    Console.WriteLine("Insert the new client name");
                    rent.ClientName = Console.ReadLine();
                    if (clientController.Validation(rent.ClientName) == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Don't exist in registers");
                        Console.ResetColor();
                        Console.WriteLine("1 - Try again");
                        Console.WriteLine("2 - Exit");
                        int clientOption = Convert.ToInt32(Console.ReadLine());

                        switch (clientOption)
                        {
                            case 1:
                                EditRent(rent.Id, rent);
                                return;
                            case 2:
                                return;
                        }

                        return;
                    }
                    break;
                case 4:
                    Console.WriteLine("Insert the new return date");
                    rent.ReturnDate = Convert.ToDateTime(Console.ReadLine());
                    break;
            }

            DataBaseController.DataBase(SqlEdit, GetParametersRents(rent));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Rent edited with success");
            Console.ReadLine();
            Console.ResetColor();
        }

        public Rent GetById(int id)
        {
            return DataBaseController.GetId(SqlSelectId, RentConvert, AddParameters("ID", id));
        }

        private Rent RentConvert(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string employeName = ((string)reader["EmployeName"]);
            int quantity = ((int)reader["MoviesQuantity"]);
            string movieName = ((string)reader["MovieName"]);
            string clientName = ((string)reader["ClientName"]);
            DateTime rentalDate = Convert.ToDateTime(reader["RentalDate"]);
            DateTime returnDate = Convert.ToDateTime(reader["ReturnDate"]);
            int price = ((int)reader["TOTALPRICE"]);

            Rent rent = new Rent(id,employeName,quantity, movieName, clientName, rentalDate, returnDate,price);

            rent.Id = id;

            return rent;
        }

        public List<Rent> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
