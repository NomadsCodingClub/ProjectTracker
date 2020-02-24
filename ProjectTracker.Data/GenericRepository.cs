using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTracker.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected DbSet<T> Entities;

        public GenericRepository(ApplicationDbContext context)
        {
            Entities = context.Set<T>();
        }

        public void Add(T Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T Entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T Entity)
        {
            throw new NotImplementedException();
        }
    }
}
