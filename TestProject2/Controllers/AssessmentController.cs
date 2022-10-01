using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProject2.Models;
using Newtonsoft.Json;

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

        [HttpGet]
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

        [HttpPost]
        public ActionResult DrillResults(DrillViewModel dvm, string txtAnswer_1, string txtAnswer_2, string txtAnswer_3, string txtAnswer_4, string txtAnswer_5, int currentTier, int studentId, List<Question> questions)
        {
            string answer1 = txtAnswer_1;
            string answer2 = txtAnswer_2;
            string answer3 = txtAnswer_3;
            string answer4 = txtAnswer_4;
            string answer5 = txtAnswer_5;
            string correctAnswer1 = dvm.DrillQuestions[1].Answer;
            
            return View();
        }

        [HttpPost]
        public ActionResult Drill(DrillViewModel model)
        {
            var correctAnswer1 = model.DrillQuestions[0].Answer;
            var userAnswer1 = model.UserAnswers[0];
            var questions = model.DrillQuestions;
            var test = 0;

            var dvm = new DrillViewModel();
            dvm.StudentId = model.StudentId;
            dvm.CurrentTier = model.CurrentTier;
            dvm.DrillQuestions = model.DrillQuestions;
            dvm.UserAnswers = model.UserAnswers;
            

            return View("DrillResults", dvm);
        }
    }
}