using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestProject.Models;

namespace TestProject2.Models
{
    public class Assessment
    {
        public String id { get; set; }
        public String title { get; set; }
        public String section { get; set; }
        public List<Question> questions { get; set; }
        public List<Question> questionsCorrect { get; set; }
        public List<Question> questionsWrong { get; set; }
        public DateTime dueDate { get; set; }
        public double grade { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int totalMinutes { get; set; }
    }
}