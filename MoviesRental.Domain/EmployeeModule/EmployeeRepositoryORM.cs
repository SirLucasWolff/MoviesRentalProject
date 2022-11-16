using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.EmployeeModule
{
    public interface EmployeeRepositoryORM : IRepository<Employee, int>, IReadOnlyRepository<Employee, int>
    {
    }
}
