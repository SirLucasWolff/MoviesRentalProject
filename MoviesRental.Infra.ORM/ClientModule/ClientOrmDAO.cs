using MoviesRental.Domain.ClientModule;
using MoviesRental.Infra.ORM.MoviesRentalModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Infra.ORM.ClientModule
{
    public class ClientOrmDAO : BaseRepository<Client, int>, ClientRepository
    {
        MoviesRentalDbContext moviesRentalDbContext;
        public ClientOrmDAO(MoviesRentalDbContext moviesRentalDbContext) : base(moviesRentalDbContext)
        {
            this.moviesRentalDbContext = moviesRentalDbContext;
        }

        public bool ExistClientWithTheName(int id, string name)
        {
            var ClientList = moviesRentalDbContext.ClientDB.ToList();
            if (ClientList == null)
            {
                return false;
            }
            else
            {
                return ClientList.Exists(x => x.ClientName == name);
            }
        }
    }
}
