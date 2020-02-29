using ProjectTracker.Data.Models;
using System;
using System.Linq;

namespace ProjectTracker.Data.Repositories
{
    public class ProjectsRepository : GenericRepository<Project>, IProjectsRepository
    {
        public ProjectsRepository(ApplicationDbContext context) : base (context) { }

        public Project GetProject(int id)
        {
            return _entities.Find(id);
        }

        public IQueryable<Project> GetProjects()
        {
            return _entities.OrderBy(p => p.ID);
        }
    }
}
