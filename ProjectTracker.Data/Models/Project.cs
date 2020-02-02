using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTracker.Data.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public User CreatedBy { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
