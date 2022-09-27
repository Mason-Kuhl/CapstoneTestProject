using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestProject2.Models
{
    public class Gradebook
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? AssesmentId { get; set; }
        public int? StudentId { get; set; }
        public DateTime DateTaken { get; set; }
        public int? Correct { get; set; }
        public int? Amount { get; set; }
        public int? PercentGrade { get; set; }
        public DateTime TotalMinutes { get; set; }
        public List<Question> QuestionsCorrect { get; set; }
        public List<Question> QuestionsWrong { get; set; }
    }
}