using ProjectTracker.Data.Models;
using System.Linq;

namespace ProjectTracker.Data
{
    public interface IProjectsRepository
    {
        Project GetProject();
        IQueryable<Project> GetProjects();
    }
}
