using ProjectTracker.Data.Models;
using System.Linq;

namespace ProjectTracker.Data.Repositories
{
    public interface IProjectsRepository : IGenericRepository<Project>
    {
        Project GetProject();
        IQueryable<Project> GetProjects();
    }
}
