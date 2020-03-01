using ProjectTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTracker.ViewModels
{
    public class ProjectForm
    {
        public IEnumerable<User> Users { get; set; }
        public Project Project { get; set; }
    }
}
