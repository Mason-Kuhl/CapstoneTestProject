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






        //test actions

        [HttpGet]
        public ActionResult Test()
        {
            var id = User.Identity.GetUserId();
            var user = _context.Users.Find(id);
            var currentTier = user.CurrentTier;
            var tvm = new TestViewModel();

            var testQuestions = _context.Questions.Where(t => t.Tier == currentTier).ToList();

            tvm.StudentId = user.StudentId;
            tvm.CurrentTier = currentTier;
            tvm.TestQuestions = testQuestions;

            return View(tvm);
        }

        [HttpPost]
        public ActionResult Test(TestViewModel model)
        {
            var correctAnswer1 = model.TestQuestions[0].Answer;
            //var userAnswer1 = model.UserAnswers[0];
            //var questions = model.DrillQuestions;
            //var test = 0;

            var tvm = new TestViewModel();
            tvm.StudentId = model.StudentId;
            tvm.CurrentTier = model.CurrentTier;
            tvm.TestQuestions = model.TestQuestions;
            tvm.UserAnswers = model.UserAnswers;

            var test = 0;

            return View("TestResults",tvm);
        }
    }
}