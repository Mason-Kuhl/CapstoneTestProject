using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProject2.Models;


namespace TestProject2.Controllers
{
    public class AssessmentController : Controller
    {
        private ApplicationDbContext _context;

        public AssessmentController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Assessment
        public ActionResult Index()
        {
            var id = User.Identity.GetUserId();
            var user = _context.Users.Find(id);

            return View(user);
        }

        public ActionResult Drill()
        {
            var id = User.Identity.GetUserId();
            var user = _context.Users.Find(id);
            var currentTier = user.CurrentTier;
            var dvm = new DrillViewModel();

            var questionsList = _context.Questions.Where(t => t.Tier == currentTier).ToList();
            var drillQuestions = new List<Question> { };
            var amountOfQuestions = questionsList.Count - 1;
            var count = 0;
            Random rnd = new Random();

            while (count < 5)
            {
                int randomNumber = rnd.Next(0, amountOfQuestions);
                drillQuestions.Add(questionsList[randomNumber]);
                questionsList.RemoveAt(randomNumber);
                amountOfQuestions--;
                count++;
            }

            dvm.StudentId = user.StudentId;
            dvm.CurrentTier = currentTier;
            dvm.DrillQuestions = drillQuestions;

            return View(dvm);
        }

        public ActionResult DrillResults(DrillViewModel dvm, string txtAnswer_1, string txtAnswer_2, string txtAnswer_3, string txtAnswer_4, string txtAnswer_5)
        {
            string answer1 = txtAnswer_1;
            string answer2 = txtAnswer_2;
            string answer3 = txtAnswer_3;
            string answer4 = txtAnswer_4;
            string answer5 = txtAnswer_5;
            var drillvm = dvm;
            var qlist = dvm.DrillQuestions;
            return View();
        }
    }
}