using StoreAccounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StoreAccounting.DataLayer.Services
{
    public class StoreRepository<TEntity> where TEntity : class
    {
        private StoreAccounting_DBEntities _db;
        private DbSet<TEntity> _dbSet;

        public StoreRepository(StoreAccounting_DBEntities db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }
        public virtual TEntity GetByEntity(object Id)
        {
            return _dbSet.Find(Id);
        }

        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderby = null, string includes = "")
        {
            IQueryable<TEntity> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }

            if (orderby != null)
            {
                query = orderby(query);
            }

            if (includes != "")
            {
                foreach (string include in includes.Split(','))
                {
                    query = query.Include(include);
                }
            }

            return query;
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public virtual void Delete(object Id)
        {
            var entity = GetByEntity(Id);
            Delete(entity);
        }
    }
}
