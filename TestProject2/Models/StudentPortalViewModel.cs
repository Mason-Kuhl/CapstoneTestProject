using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProject2.Models
{
    public class StudentPortalViewModel
    {
        public ApplicationUser User { get; set; }
        public List<Guardian> StudentIds { get; set; }
    }
}