using Microsoft.EntityFrameworkCore;
using MoviesRental.Domain;
using MoviesRental.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Infra.ORM.MoviesRentalModule
{
    public class BaseRepository<TEntity, TKey> : IRepository<TEntity, TKey>,
        IReadOnlyRepository<TEntity, TKey>
        where TEntity : BaseEntity<TKey>, new()
    {
        private MoviesRentalDbContext moviesRentalDbContext;
        private readonly DbSet<TEntity> dbSet;

        public BaseRepository(MoviesRentalDbContext moviesRentalDbContext)
        {
            this.moviesRentalDbContext = moviesRentalDbContext;
            this.dbSet = moviesRentalDbContext.Set<TEntity>();
        }

        public bool Delete(int id)
        {
            TEntity baseEntityToRemove = null;
            try
            {
                baseEntityToRemove = SelectById(id);
            
                dbSet.Remove(baseEntityToRemove);
                moviesRentalDbContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Edit(int id, TEntity baseEntity)
        {
            try
            {
                if (moviesRentalDbContext.Entry(baseEntity).State != EntityState.Modified)
                {
                    var oldEntity = SelectById(id);

                    baseEntity.Id = id;

                    moviesRentalDbContext.Entry(oldEntity).CurrentValues.SetValues(baseEntity);
                }

                moviesRentalDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Exist(int id)
        {
            return dbSet.ToList().Exists(x => x.Id == id);
        }

        public bool InsertNew(TEntity baseEntity)
        {
            try
            {
                dbSet.Add(baseEntity);
                moviesRentalDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<TEntity> SelectAll()
        {
            return dbSet.ToList();
        }

        public TEntity SelectById(int id)
        {
            return dbSet.ToList().Find(x => x.Id == id);
        }
    }
}
