using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProject2.Models
{
    public class DrillViewModel
    {
        public int StudentId { get; set; }
        public int CurrentTier { get; set; }
        public List<Question> DrillQuestions { get; set; }


    }
}