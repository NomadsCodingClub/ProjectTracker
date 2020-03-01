using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectTracker.Data;
using ProjectTracker.Data.Models;
using ProjectTracker.Data.Repositories;
using ProjectTracker.ViewModels;

namespace ProjectTracker.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjectsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IQueryable<Project> projects = _unitOfWork.ProjectsRepository.GetProjects();
            
            return View(projects);
        }

        public IActionResult Project(int id)
        {
            Project project = _unitOfWork.ProjectsRepository.GetProject(id);

            return View(project);
        }

        public IActionResult Add()
        {
            //TODO Remove test code
            IEnumerable<User> users = new List<User>();

            ProjectForm projectForm = new ProjectForm(users);
            return View(projectForm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(ProjectForm projectForm)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ProjectsRepository.Add(projectForm.Project);
                _unitOfWork.Save();
                
                return RedirectToAction(nameof(Index));
            }

            return View(projectForm);
        }
    }
}