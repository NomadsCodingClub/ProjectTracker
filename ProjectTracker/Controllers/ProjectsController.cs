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
        private readonly IUnitOfWork UnitOfWork;

        public ProjectsController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IQueryable<Project> projects = UnitOfWork.ProjectsRepository.GetProjects();
            
            return View(projects);
        }
    }
}