using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectTracker.Data;
using ProjectTracker.Data.Models;

namespace ProjectTracker.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IProjectsRepository ProjectsRepository;

        public ProjectsController(IProjectsRepository projectsRepository)
        {
            ProjectsRepository = projectsRepository;
        }

        public IActionResult Index()
        {
            IQueryable<Project> projects = ProjectsRepository.GetProjects();

            return View(projects);
        }
    }
}