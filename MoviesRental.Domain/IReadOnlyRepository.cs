using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Domain
{
    public interface IReadOnlyRepository <TEntity,TKey>
    {
        List<TEntity> SelectAll();

        TEntity SelectById(int id);
    }
}
