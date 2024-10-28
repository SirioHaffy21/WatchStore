using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace WatchManageStore.Infrastructure
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity Find(Expression<Func<TEntity, bool>> condition);

        IList<TEntity> FindByCondition(Expression<Func<TEntity, bool>> condition);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
        void DeleteByCondition(Func<TEntity, bool> condition);

        void DeleteRange(List<TEntity> entities);
        IList<TEntity> GetAll();
    }
}
