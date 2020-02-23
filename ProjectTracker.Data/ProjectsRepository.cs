using ProjectTracker.Data.Models;
using System;
using System.Linq;

namespace ProjectTracker.Data
{
    public class ProjectsRepository : IProjectsRepository
    {
        private readonly ApplicationDbContext Context;

        public ProjectsRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public Project GetProject()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Project> GetProjects()
        {
            return Context.Projects;
        }
    }
}
