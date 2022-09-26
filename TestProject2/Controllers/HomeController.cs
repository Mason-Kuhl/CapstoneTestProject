using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProject2.Models;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace TestProject2.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult StudentPortal()
        {
            var students = new List<Guardian>();
            var id = User.Identity.GetUserId();
            var user = _context.Users.Find(id);

            if (user.Role == "Guardian")
            {
                students = _context.Guardians.Where(u => u.UserId == id).ToList();
            }

            var spvm = new StudentPortalViewModel();
            spvm.User = user;
            spvm.StudentIds = students;

            return View(spvm);
        }
    }
}