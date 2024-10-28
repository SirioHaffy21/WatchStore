using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WatchManageStore.Data;

namespace WatchManageStore.Infrastructure
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDBContext _context;
        public DbSet<TEntity> _dbSet { get; set; }

        public BaseRepository(ApplicationDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            if (entity != null)
            {
                _dbSet.Add(entity);
            }
        }

        public void Delete(TEntity entity)
        {
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }

        public virtual TEntity Find(Expression<Func<TEntity, bool>> condition)
        {
            return _dbSet.FirstOrDefault(condition);
        }
        public virtual void DeleteByCondition(Func<TEntity, bool> condition)
        {
            var query = _dbSet.Where(condition);
            foreach (var entity in query)
            {
                this.Delete(entity);
            }
        }

        public IList<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Update(TEntity entity)
        {
            if (entity != null)
            {
                _dbSet.Update(entity);
            }
        }
        public void DeleteRange(List<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public virtual IList<TEntity> FindByCondition(Expression<Func<TEntity, bool>> condition)
        {
            return _dbSet.Where(condition).ToList();
        }
    }
}

