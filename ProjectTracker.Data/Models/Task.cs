using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectTracker.Data.Models
{
    public class Task
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public virtual Status Status { get; set; }

        public virtual User Owner { get; set; }

        public virtual Project Project { get; set; }

        [Display(Name = "Created On")]
        public DateTime CreatedOn { get; set; }
        
        public virtual User CreatedBy { get; set; }
    }
}