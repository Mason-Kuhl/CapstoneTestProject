using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestProject2.Models;

namespace TestProject2.Controllers
{
    public class GradebooksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Gradebooks
        public ActionResult Index()
        {
            return View(db.Gradebooks.ToList());
        }

        // GET: Gradebooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gradebook gradebook = db.Gradebooks.Find(id);
            if (gradebook == null)
            {
                return HttpNotFound();
            }
            return View(gradebook);
        }

        // GET: Gradebooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gradebooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AssesmentId,StudentId,DateTaken,Correct,Amount,PercentGrade,TotalMinutes")] Gradebook gradebook)
        {
            if (ModelState.IsValid)
            {
                db.Gradebooks.Add(gradebook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gradebook);
        }

        // GET: Gradebooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gradebook gradebook = db.Gradebooks.Find(id);
            if (gradebook == null)
            {
                return HttpNotFound();
            }
            return View(gradebook);
        }

        // POST: Gradebooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AssesmentId,StudentId,DateTaken,Correct,Amount,PercentGrade,TotalMinutes")] Gradebook gradebook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gradebook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gradebook);
        }

        // GET: Gradebooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gradebook gradebook = db.Gradebooks.Find(id);
            if (gradebook == null)
            {
                return HttpNotFound();
            }
            return View(gradebook);
        }

        // POST: Gradebooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Gradebook gradebook = db.Gradebooks.Find(id);
            db.Gradebooks.Remove(gradebook);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
