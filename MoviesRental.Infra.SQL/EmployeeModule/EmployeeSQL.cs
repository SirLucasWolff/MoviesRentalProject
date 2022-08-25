using MoviesRental.Domain.EmployeeModule;
using MoviesRental.Infra.SQL;
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
                        [Name],
                        [Password],
                        [AccessKey]
                    )
                    VALUES
                    (
                        @Email,
                        @Name,
                        @Password,
                        @AccessKey
                    )";

        public string SqlSelect = @"SELECT * FROM EmployeeDB";

        public string SqlDelete = @"DELETE FROM EmployeeDB WHERE ID = @Id";

        public string SqlEdit = @"UPDATE EmployeeDB
                    SET
                        [Email] = @Email,
                        [Name] = @Name,
                        [Password] = @Password,
                        [AccessKey] = @AccessKey
                    WHERE 
                        ID = @ID";

        public string SqlSelectId = @"SELECT
                        [ID],
                        [Email],
                        [NAME],
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
                        [NAME],
                        [PASSWORD],
                        [ACCESSKEY]
          
                        FROM EmployeeDB";

        public bool InsertNew(Employee employee)
        {
            try
            {
                DataBaseController.DataBase(SqlInsert, GetParametersEmployees(employee));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }         
        }

        private Dictionary<string, object> GetParametersEmployees(Employee employee)
        {
            var parameters = new Dictionary<string, object>();

            parameters.Add("ID", employee.Id);
            parameters.Add("EMAIL", employee.Email);
            parameters.Add("NAME", employee.Name);
            parameters.Add("PASSWORD", employee.Password);
            parameters.Add("ACCESSKEY", employee.AccessKey);

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

        public bool Edit(int id, Employee employee)
        {
            try
            {
                DataBaseController.DataBase(SqlEdit, GetParametersEmployees(employee));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public List<Employee> SelectAll()
        {
            return DataBaseController.GetAll(SqlSelectAll, EmployeeConvert);
        }

        public Employee SelectById(int id)
        {
            return DataBaseController.GetId(SqlSelectId, EmployeeConvert, AddParameters("ID", id));
        }

        private Employee EmployeeConvert(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string email = ((string)reader["EMAIL"]);
            string employeeName = ((string)reader["NAME"]);
            string password = ((string)reader["PASSWORD"]);
            string accessKey = ((string)reader["ACCESSKEY"]);

            Employee employee = new Employee(email, employeeName, password, accessKey);

            employee.Id = id;

            return employee;
        }

        public bool ExistEmployeeWithTheName(int id, string name)
        {
            throw new NotImplementedException();
        }

        public bool Exist(int id)
        {
            throw new NotImplementedException();
        }
    }
}
