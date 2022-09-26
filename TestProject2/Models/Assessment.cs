using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TestProject.Models;

namespace TestProject2.Models
{
    public class Assessment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public String Id { get; set; }
        public String Title { get; set; }
        public int? Tier { get; set; }
        public int? AmountOfQuestions { get; set; }
        public List<Question> Questions { get; set; }
        public DateTime DueDate { get; set; }
        public double? Grade { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int? TotalMinutes { get; set; }
    }
}