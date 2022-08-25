using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.ClientModule
{
    public interface ClientRepository: IRepository<Client, int>, IReadOnlyRepository<Client, int>
    {
        public bool ExistClientWithTheName(int id, string name);
    }
}
