using MoviesRental.DataBase;
using MoviesRental.Domain.EmployeModule;
using RentalMovies.Screen.EmployeModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Controller.EmployeModule
{
    public class EmployeController : EmployeRepository
    {
        EmployeScreen employeScreen = new EmployeScreen();

        List<Employe> employesList = new List<Employe>();

        public string SqlInsert = @"INSERT INTO EMPLOYEDB
                    (
                        [Name],
                        [Password]
                    )
                    VALUES
                    (
                        @Name,
                        @Password
                    )";

        public string SqlSelect = @"SELECT * FROM EMPLOYEDB";

        public string SqlDelete = @"DELETE FROM EMPLOYEDB WHERE ID = @Id";

        public string SqlEdit = @"UPDATE EMPLOYEDB
                    SET
                        [Name] = @Name,
                        [Password] = @Password
                    WHERE 
                        ID = @ID";

        public string SqlSelectId = @"SELECT
                        [ID],
                        [NAME],
                        [PASSWORD]
	                FROM
                        EMPLOYEDB
                    WHERE 
                        ID = @ID";

        public string SqlSelectAll =
        @"SELECT
                        [ID],
                        [NAME],
                        [PASSWORD]
          
                        FROM EMPLOYEDB";

        public void AddEmploye(Employe employe)
        {
            Console.Clear();

            Random rnd = new Random();
            employe.id = rnd.Next();

            Console.WriteLine("Insert the employe name:");
            employe.Name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insert the employe password:");
            employe.Password = Convert.ToString(Console.ReadLine());

            DataBaseController.DataBase(SqlInsert,GetParametersEmploye(employe));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Employe created with success");
            Console.ReadLine();
            Console.ResetColor();
        }

        public void DeleteEmploye(int id)
        {
            Console.Clear();

            ShowEmployees();

            Console.WriteLine("Select the employe id to delete:");
            id = Convert.ToInt32(Console.ReadLine());

            DataBaseController.DataBase(SqlDelete, AddParameters("ID", id));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Employe deleted with success");
            Console.ReadLine();
            Console.ResetColor();
        }

        private Dictionary<string, object> AddParameters(string v, int id)
        {
            return new Dictionary<string, object>() { { v, id } };
        }

        public void ShowEmployees()
        {
            employeScreen.ShowEmployees(SqlSelect);
        }

        public void EditEmploye(int id,Employe employe)
        {
            Console.Clear();

            ShowEmployees();

            Console.WriteLine("Select the employe id to edit:");
            id = Convert.ToInt32(Console.ReadLine());

            employe = GetById(id);

            Console.WriteLine("1 - Edit the name");
            Console.WriteLine("2 - Edit the password");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Insert the new name");
                    employe.Name = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Insert the new password");
                    employe.Password = Console.ReadLine();
                    break;
            }

            DataBaseController.DataBase(SqlEdit, GetParametersEmploye(employe));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Employe edited with success");
            Console.ReadLine();
            Console.ResetColor();
        }

        public Employe GetById(int id)
        {
            return DataBaseController.GetId(SqlSelectId, EmployeConvert, AddParameters("ID", id));
        }

        private Dictionary<string, object> GetParametersEmploye(Employe employe)
        {
            var parameters = new Dictionary<string, object>();

            parameters.Add("ID", employe.id);
            parameters.Add("NAME", employe.Name);
            parameters.Add("PASSWORD", employe.Password);

            return parameters;
        }

        private Employe EmployeConvert(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string name = ((string)reader["NAME"]);
            string password = ((string)reader["PASSWORD"]);
            
            Employe employe = new Employe(id,name, password);

            employe.id = id;

            return employe;
        }

        public List<Employe> GetAll()
        {
            return DataBaseController.GetAll(SqlSelectAll, EmployeConvert);
        }

        public bool Validation(string rent)
        {
            employesList = GetAll();

            foreach (var item in employesList)
            {
                if (item.Name == rent)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
