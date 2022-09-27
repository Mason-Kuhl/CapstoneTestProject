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
    }
}