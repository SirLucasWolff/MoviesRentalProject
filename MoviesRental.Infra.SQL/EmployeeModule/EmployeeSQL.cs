using MoviesRental.DataBase;
using MoviesRental.Domain.EmployeeModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Infra.SQL.EmployeeModule
{
    public class EmployeeSQL : EmployeeRepository
    {
        public string SqlInsert = @"INSERT INTO EmployeeDB
                    (
                        [Email],
                        [EmployeeName],
                        [Password],
                        [AccessKey]
                    )
                    VALUES
                    (
                        @Email,
                        @EmployeeName,
                        @Password,
                        @AccessKey
                    )";

        public string SqlSelect = @"SELECT * FROM EmployeeDB";

        public string SqlDelete = @"DELETE FROM EmployeeDB WHERE ID = @Id";

        public string SqlEdit = @"UPDATE EmployeeDB
                    SET
                        [Email] = @Email,
                        [EmployeeName] = @EmployeeName,
                        [Password] = @Password,
                        [AccessKey] = @AccessKey
                    WHERE 
                        ID = @ID";

        public string SqlSelectId = @"SELECT
                        [ID],
                        [Email],
                        [EMPLOYEENAME],
                        [PASSWORD],
                        [ACCESSKEY]
	                FROM
                        EmployeeDB
                    WHERE 
                        ID = @ID";

        public string SqlSelectAll =
        @"SELECT
                        [ID],
                        [Email],
                        [EMPLOYEENAME],
                        [PASSWORD],
                        [ACCESSKEY]
          
                        FROM EmployeeDB";

        public void AddEmployee(Employee employee)
        {
            DataBaseController.DataBase(SqlInsert, GetParametersEmployees(employee));
        }

        private Dictionary<string, object> GetParametersEmployees(Employee employee)
        {
            var parameters = new Dictionary<string, object>();

            parameters.Add("ID", employee.Id);
            parameters.Add("EMAIL", employee.Email);
            parameters.Add("EMPLOYEENAME", employee.Name);
            parameters.Add("PASSWORD", employee.Password);
            parameters.Add("ACCESSKEY", employee.AccessKey);

            return parameters;
        }
    

        public void DeleteEmployee(int id)
        {
            DataBaseController.DataBase(SqlDelete, AddParameters("ID", id));
        }

        private Dictionary<string, object> AddParameters(string v, int id)
        {
            return new Dictionary<string, object>() { { v, id } };
        }

        public void EditEmployee(int id, Employee employee)
        {
            DataBaseController.DataBase(SqlEdit, GetParametersEmployees(employee));
        }

        public List<Employee> GetAll()
        {
            return DataBaseController.GetAll(SqlSelectAll, EmployeeConvert);
        }

        public Employee GetById(int id)
        {
            return DataBaseController.GetId(SqlSelectId, EmployeeConvert, AddParameters("ID", id));
        }

        private Employee EmployeeConvert(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string email = ((string)reader["EMAIL"]);
            string employeeName = ((string)reader["EMPLOYEENAME"]);
            string password = ((string)reader["PASSWORD"]);
            string accessKey = ((string)reader["ACCESSKEY"]);

            Employee employee = new Employee(id, email, employeeName, password, accessKey);

            employee.Id = id;

            return employee;
        }

    }
}
