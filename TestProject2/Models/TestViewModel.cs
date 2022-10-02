using System.Collections.Generic;
using TestProject2.Models;

namespace TestProject2.Controllers
{
    public class TestViewModel
    {
        public int Id { get; set; }
        public int Tier { get; set; }
        public int AmountOfQuestions { get; set; }
        public List<Question> Questions { get; set; }

    }
}