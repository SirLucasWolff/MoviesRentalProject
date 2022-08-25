using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.RentModule
{
    public interface RentOtherRepository
    {
        List<Rent> GetByStatus(string status);
    }
}
