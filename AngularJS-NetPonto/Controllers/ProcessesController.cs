using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJS_NetPonto.Models;

namespace AngularJS_NetPonto.Controllers
{
    public class ProcessesController : Controller
    {
        private AngularJS_NetPontoContext db = new AngularJS_NetPontoContext();

        //
        // GET: /Processes/

        public ActionResult Index()
        {
            return View(db.Processes.ToList());
        }

        public JsonResult GetProcesses()
        {
            return Json(db.Processes.AsEnumerable(), JsonRequestBehavior.AllowGet);
        }

        //
        // GET: /Processes/Details/5

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
        // GET: /Processes/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Processes/Create

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
        // GET: /Processes/Edit/5

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
        // POST: /Processes/Edit/5

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
        // GET: /Processes/Delete/5

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
        // POST: /Processes/Delete/5

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