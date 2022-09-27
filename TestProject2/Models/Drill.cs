using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestProject2.Models
{
    public class Drill
    {
        public int Id { get; set; }
        public int Tier { get; set; }
        public int AmountOfQuestions { get; set; }
        public List<Question> Questions { get; set; }
        
    }
}