using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.EmployeeModule
{
    public interface EmployeeRepository: IRepository<Employee, int>, IReadOnlyRepository<Employee, int>
    {
        public bool ExistEmployeeWithTheName(int id, string name);
    }
}
