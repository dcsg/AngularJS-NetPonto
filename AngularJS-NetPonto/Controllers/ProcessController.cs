using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJS_NetPonto.Models;
using AngularJS_NetPonto.DAL;

namespace AngularJS_NetPonto.Controllers
{
    public class ProcessController : Controller
    {
        private AngularJSContext db = new AngularJSContext();

        //
        // GET: /Process/

        public ActionResult Index()
        {
            return View(db.Processes.ToList());
        }



        //
        // GET: /Process/Details/5

        public ActionResult Details(int id = 0)
        {
            Process process = db.Processes.Find(id);
            if (process == null)
            {
                return HttpNotFound();
            }
            return View(process);
        }

        //
        // GET: /Process/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Process/Create

        [HttpPost]
        public ActionResult Create(Process process)
        {
            if (ModelState.IsValid)
            {
                db.Processes.Add(process);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(process);
        }

        //
        // GET: /Process/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Process process = db.Processes.Find(id);
            if (process == null)
            {
                return HttpNotFound();
            }
            return View(process);
        }

        //
        // POST: /Process/Edit/5

        [HttpPost]
        public ActionResult Edit(Process process)
        {
            if (ModelState.IsValid)
            {
                db.Entry(process).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(process);
        }

        //
        // GET: /Process/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Process process = db.Processes.Find(id);
            if (process == null)
            {
                return HttpNotFound();
            }
            return View(process);
        }

        //
        // POST: /Process/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Process process = db.Processes.Find(id);
            db.Processes.Remove(process);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}