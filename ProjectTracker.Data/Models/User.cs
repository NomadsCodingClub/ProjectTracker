using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ProjectTracker.Data.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }

        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
