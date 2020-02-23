using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectTracker.Data.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }

        [Display(Name = "Posted On")]
        public DateTime PostedOn { get; set; }
        public virtual User User { get; set; }
        public virtual Task Task { get; set; }
    }
}
