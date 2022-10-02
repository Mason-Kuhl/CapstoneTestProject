using System;
using System.Collections.Generic;

namespace TestProject2.Models
{
    public class TestViewModel
    {
        public int StudentId { get; set; }
        public int CurrentTier { get; set; }
        public List<Question> TestQuestions { get; set; }
        public List<string> UserAnswers { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}