using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WarriorCombatAcademyTrainer.DAL;
using WarriorCombatAcademyTrainer.Models;

namespace WarriorCombatAcademyTrainer.Controllers
{
    public class SubmissionLogController : Controller
    {
        private TrainingContext db = new TrainingContext();

        // GET: SubmissionLog
        public ActionResult Index()
        {
            return View(db.SubmissionLogs.ToList());
        }

        // GET: SubmissionLog/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubmissionLog submissionLog = db.SubmissionLogs.Find(id);
            if (submissionLog == null)
            {
                return HttpNotFound();
            }
            return View(submissionLog);
        }

        // GET: SubmissionLog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubmissionLog/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,OpponentName,Position,WinLoss,DateOfEvent,StudentID")] SubmissionLog submissionLog)
        {
            if (ModelState.IsValid)
            {
                db.SubmissionLogs.Add(submissionLog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(submissionLog);
        }

        // GET: SubmissionLog/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubmissionLog submissionLog = db.SubmissionLogs.Find(id);
            if (submissionLog == null)
            {
                return HttpNotFound();
            }
            return View(submissionLog);
        }

        // POST: SubmissionLog/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,OpponentName,Position,WinLoss,DateOfEvent,StudentID")] SubmissionLog submissionLog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(submissionLog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(submissionLog);
        }

        // GET: SubmissionLog/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubmissionLog submissionLog = db.SubmissionLogs.Find(id);
            if (submissionLog == null)
            {
                return HttpNotFound();
            }
            return View(submissionLog);
        }

        // POST: SubmissionLog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SubmissionLog submissionLog = db.SubmissionLogs.Find(id);
            db.SubmissionLogs.Remove(submissionLog);
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
