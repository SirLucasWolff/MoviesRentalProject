using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.EmployeeModule
{
    public interface EmployeeRepository
    {
        Employee GetById(int id);

        void AddEmployee(Employee employee);

        void DeleteEmployee(int id);

        void EditEmployee(int id,Employee employee);

        List<Employee> GetAll();
    }
}
