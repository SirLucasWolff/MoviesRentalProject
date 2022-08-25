using MoviesRental.Domain.ClientModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain
{
    public interface IRepository<TBaseEntity,Tkey>
    {
        bool InsertNew(TBaseEntity baseEntity);

        bool Edit(int id, TBaseEntity baseEntity);

        bool Delete(int id);

        bool Exist(int id);
    }
}
