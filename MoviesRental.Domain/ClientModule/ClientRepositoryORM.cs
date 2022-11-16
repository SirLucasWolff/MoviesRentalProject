using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain.ClientModule
{
    public interface ClientRepositoryORM : IRepository<Client, int>, IReadOnlyRepository<Client, int>
    {
        public bool ExistClientWithTheNameOrm(int id, string name);
    }
}
