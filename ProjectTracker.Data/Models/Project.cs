using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectTracker.Data.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [HiddenInput]
        public DateTime CreatedOn { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
