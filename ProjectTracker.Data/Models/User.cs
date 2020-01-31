using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTracker.Data.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
