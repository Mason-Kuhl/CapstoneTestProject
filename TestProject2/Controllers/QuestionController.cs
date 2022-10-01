using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProject2.Models;

namespace TestProject2.Controllers
{
    public class QuestionController : Controller
    {
        private ApplicationDbContext _context;

        public QuestionController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Question
        [Authorize]
        public ActionResult Index()
        {
            var questions = _context.Questions.OrderBy(q => q.Tier).ToList();

            if (User.IsInRole("Teacher"))
            {
                return View(questions);
            }
            return HttpNotFound();
        }

        [Authorize]
        public ActionResult Delete(int id)
        {
            var question = _context.Questions.FirstOrDefault(q => q.Id == id);
            _context.Questions.Remove(question);
            _context.SaveChanges();

            return View();

        }
    }
}