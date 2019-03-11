using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FilmReviewMVC.Models;

namespace FilmReviewMVC.Controllers
{
    public class ActorCommentsController : Controller
    {
        private FilmContext db = new FilmContext();

        // GET: ActorComments
        public ActionResult Index()
        {
            var actorComments = db.ActorComments.Include(a => a.Actor);
            return View(actorComments.ToList());
        }

        // GET: ActorComments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActorComment actorComment = db.ActorComments.Find(id);
            if (actorComment == null)
            {
                return HttpNotFound();
            }
            return View(actorComment);
        }

        // GET: ActorComments/Create
        public ActionResult Create()
        {
            ViewBag.ActorID = new SelectList(db.Actors, "ActorID", "ActorName");
            return View();
        }

        // POST: ActorComments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ActorCommentID,ActorID,Comment,DateAdded")] ActorComment actorComment)
        {
            if (ModelState.IsValid)
            {
                db.ActorComments.Add(actorComment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ActorID = new SelectList(db.Actors, "ActorID", "ActorName", actorComment.ActorID);
            return View(actorComment);
        }

        // GET: ActorComments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActorComment actorComment = db.ActorComments.Find(id);
            if (actorComment == null)
            {
                return HttpNotFound();
            }
            ViewBag.ActorID = new SelectList(db.Actors, "ActorID", "ActorName", actorComment.ActorID);
            return View(actorComment);
        }

        // POST: ActorComments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ActorCommentID,ActorID,Comment,DateAdded")] ActorComment actorComment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actorComment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ActorID = new SelectList(db.Actors, "ActorID", "ActorName", actorComment.ActorID);
            return View(actorComment);
        }

        // GET: ActorComments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActorComment actorComment = db.ActorComments.Find(id);
            if (actorComment == null)
            {
                return HttpNotFound();
            }
            return View(actorComment);
        }

        // POST: ActorComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ActorComment actorComment = db.ActorComments.Find(id);
            db.ActorComments.Remove(actorComment);
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
