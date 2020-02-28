using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTracker.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext DbContext;

        public IProjectsRepository ProjectsRepository { get; }

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;

            ProjectsRepository = new ProjectsRepository(DbContext);
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }
    }
}
