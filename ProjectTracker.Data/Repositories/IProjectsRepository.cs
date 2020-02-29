using ProjectTracker.Data.Models;
using System.Linq;

namespace ProjectTracker.Data.Repositories
{
    public interface IProjectsRepository : IGenericRepository<Project>
    {
        Project GetProject(int id);
        IQueryable<Project> GetProjects();
    }
}
