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
            var startTime = DateTime.Now;
            var tvm = new TestViewModel();

            var testQuestions = _context.Questions.Where(t => t.Tier == currentTier).ToList();

            tvm.StudentId = user.StudentId;
            tvm.CurrentTier = currentTier;
            tvm.TestQuestions = testQuestions;
            tvm.StartTime = startTime;

            return View(tvm);
        }

        [HttpPost]
        public ActionResult Test(TestViewModel model)
        {
            var endTime = DateTime.Now;
            var numberOfQuestions = model.TestQuestions.Count;
            var correctAnswers = 0;

            var tvm = new TestViewModel();
            tvm.StudentId = model.StudentId;
            tvm.CurrentTier = model.CurrentTier;
            tvm.TestQuestions = model.TestQuestions;
            tvm.UserAnswers = model.UserAnswers;
            tvm.StartTime = model.StartTime;
            tvm.EndTime = endTime;

            var minutes = (endTime - model.StartTime).TotalMinutes;
            minutes = Math.Round(minutes, 1);

            for (int i = 0; i < model.TestQuestions.Count; i++)
            {
                if (model.UserAnswers[i] == model.TestQuestions[i].Answer)
                {
                    correctAnswers++;
                }
            }
            double percentGrade = (Double.Parse(correctAnswers.ToString()) / Double.Parse(numberOfQuestions.ToString())) * 100;
            //percentGrade = Math.Round(percentGrade, 2);

            Gradebook gradebook = new Gradebook();
            gradebook.StudentId = model.StudentId;
            gradebook.DateTaken = model.StartTime;
            gradebook.Correct = correctAnswers;
            gradebook.Amount = numberOfQuestions;
            gradebook.PercentGrade = percentGrade;
            gradebook.Minutes = minutes;

            _context.Gradebooks.Add(gradebook);
            _context.SaveChanges();

            return View("TestResults",tvm);
        }
    }
}