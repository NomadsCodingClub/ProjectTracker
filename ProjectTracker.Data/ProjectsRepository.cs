using ProjectTracker.Data.Models;
using System;
using System.Linq;

namespace ProjectTracker.Data
{
    public class ProjectsRepository : GenericRepository<Project>, IProjectsRepository
    {
        public ProjectsRepository(ApplicationDbContext context) : base (context) { }

        public Project GetProject()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Project> GetProjects()
        {
            return Entities.OrderBy(p => p.ID);
        }
    }
}
