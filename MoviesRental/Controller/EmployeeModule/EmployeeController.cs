using MoviesRental.DataBase;
using MoviesRental.Domain.EmployeeModule;
using RentalMovies.Screen.EmployeeModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Controller.EmployeeModule
{
    public class EmployeeController : EmployeeRepository
    {
        EmployeeScreen employeScreen = new EmployeeScreen();

        List<Employee> employesList = new List<Employee>();

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

        public void AddEmployee(Employee employe)
        {
            Console.Clear();

            Random rnd = new Random();
            employe.Id = rnd.Next();

            Console.WriteLine("Insert the employe name:");
            employe.Name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insert the employe password:");
            employe.Password = Convert.ToString(Console.ReadLine());

            DataBaseController.DataBase(SqlInsert,GetParametersEmployee(employe));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Employee created with success");
            Console.ReadLine();
            Console.ResetColor();
        }

        public void DeleteEmployee(int id)
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

        public void EditEmployee(int id,Employee employee)
        {
            Console.Clear();

            ShowEmployees();

            Console.WriteLine("Select the employee id to edit:");
            id = Convert.ToInt32(Console.ReadLine());

            employee = GetById(id);

            Console.WriteLine("1 - Edit the name");
            Console.WriteLine("2 - Edit the password");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Insert the new name");
                    employee.Name = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Insert the new password");
                    employee.Password = Console.ReadLine();
                    break;
            }

            DataBaseController.DataBase(SqlEdit, GetParametersEmployee(employee));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Employe edited with success");
            Console.ReadLine();
            Console.ResetColor();
        }

        public Employee GetById(int id)
        {
            return DataBaseController.GetId(SqlSelectId, EmployeeConvert, AddParameters("ID", id));
        }

        private Dictionary<string, object> GetParametersEmployee(Employee employee)
        {
            var parameters = new Dictionary<string, object>();

            parameters.Add("ID", employee.Id);
            parameters.Add("NAME", employee.Name);
            parameters.Add("PASSWORD", employee.Password);

            return parameters;
        }

        private Employee EmployeeConvert(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string name = ((string)reader["NAME"]);
            string password = ((string)reader["PASSWORD"]);
            
            Employee employee = new Employee(id,name, password);

            employee.Id = id;

            return employee;
        }

        public List<Employee> GetAll()
        {
            return DataBaseController.GetAll(SqlSelectAll, EmployeeConvert);
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

        public List<Employee> GetName(int id)
        {
            throw new NotImplementedException();
        }
    }
}
