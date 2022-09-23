using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Web.Mvc;
using TestProject2.Models;

namespace TestProject2.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext _context;

        public UserController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: User
        [Authorize]
        public ViewResult Index()
        {
            var users = _context.Users.ToList();

            if (User.IsInRole("Admin"))
            {
                return View("Index", users);
            }
            else
            {
                return View("IndexReadOnly", users);
            }
        }

        public ActionResult Details(string id)
        {
            var user = _context.Users.SingleOrDefault( u => u.Id == id);

            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        public ActionResult Delete(string id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);

            _context.Users.Remove(user);

            _context.SaveChanges();

            return View(user);
        }
    }
}