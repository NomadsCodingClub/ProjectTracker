using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTracker.Data.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
