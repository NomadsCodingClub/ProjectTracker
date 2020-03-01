using Microsoft.AspNetCore.Identity;
using ProjectTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTracker.ViewModels
{
    public class ProjectForm
    {
        public IEnumerable<IdentityUser> Users { get; private set; }
        public Project Project { get; private set; }

        public ProjectForm(IEnumerable<IdentityUser> users, Project project = null)
        {
            Users = users;

            if (project != null)
            {
                Project = project;
            }
            else
            {
                Project = new Project
                {
                    CreatedOn = DateTime.Now
                };
            }
        }
    }
}
