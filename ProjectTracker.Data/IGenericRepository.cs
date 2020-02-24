using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTracker.Data
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T Entity);
        void Delete(T Entity);
        void Update(T Entity);
    }
}
