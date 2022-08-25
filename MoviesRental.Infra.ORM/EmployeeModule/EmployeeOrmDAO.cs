using MoviesRental.Domain.ClientModule;
using MoviesRental.Domain.EmployeeModule;
using MoviesRental.Infra.ORM.MoviesRentalModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Infra.ORM.EmployeeModule
{
    public class EmployeeOrmDAO : BaseRepository<Employee, int>, EmployeeRepository
    {
        MoviesRentalDbContext moviesRentalDbContext;
        public EmployeeOrmDAO(MoviesRentalDbContext moviesRentalDbContext) : base(moviesRentalDbContext)
        {
            this.moviesRentalDbContext = moviesRentalDbContext;
        }

        public bool ExistEmployeeWithTheName(int id, string name)
        {
            var EmployeeList = moviesRentalDbContext.EmployeeDB.ToList();
            if (EmployeeList == null)
            {
                return false;
            }
            else
            {
                return EmployeeList.Exists(x => x.Name == name);
            }
        }
    }
}
