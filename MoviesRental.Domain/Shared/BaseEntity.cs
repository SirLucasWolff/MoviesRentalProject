using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.Shared
{
    public abstract class BaseEntity <Tkey>
    {
        public int Id { get; set; }
    }
}
