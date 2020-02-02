using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTracker.Data.Models
{
    public class Task
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public User Owner { get; set; }
        public DateTime DueDate { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public User CreatedBy { get; set; }
        public virtual Project Project { get; set; }
    }
}