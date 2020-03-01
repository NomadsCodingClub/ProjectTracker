using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTracker.Data.Models
{
    public class Message
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public virtual IdentityUser From { get; set; }
        public virtual IdentityUser To { get; set; }
    }
}
