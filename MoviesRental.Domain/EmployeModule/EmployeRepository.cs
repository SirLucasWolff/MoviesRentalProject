using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.EmployeModule
{
    public interface EmployeRepository
    {
        Employe GetById(int id);

        void AddEmploye(Employe employer);

        void DeleteEmploye(int id);

        void EditEmploye(int id,Employe employer);

        List<Employe> GetAll();
    }
}
