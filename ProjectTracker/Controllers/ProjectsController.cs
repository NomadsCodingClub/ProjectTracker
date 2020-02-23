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
        //TODO: Implement respository 
        private readonly ApplicationDbContext Db;

        public ProjectsController(ApplicationDbContext db)
        {
            Db = db;
        }

        public IActionResult Index()
        {
            IQueryable<Project> projects = Db.Projects.OrderBy(p => p.Name);

            return View(projects);
        }
    }
}