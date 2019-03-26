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
    public class FilmsController : Controller
    {

        //private List<Film> _films = new List<Film>()
        //{
        //    new Film
        //    { FilmID = 1,
        //    FilmName = "Madagascar",
        //    Studio = "Dreamworks",
        //    Rating = "10"}
        //};
        
        private FilmContext db = new FilmContext();

        // GET: Films
        public ActionResult Index()
        {
            //ViewBag.Userid = User.Identity.GetUserId();
            //return View(_films);
            var films = db.Films.Include(f => f.Actor).Include(f => f.Director).Include(f => f.Genre);
            return View(films.ToList());
        }

        // GET: Films/Details/5
        public ActionResult Details(int? id)
        {
            //if (id == null) return new HttpNotFoundResult();

            //Film selectedFilm = _films.First(f => f.FilmID == id);

            //if (selectedFilm == null) return new HttpNotFoundResult();

            //return View(selectedFilm);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // GET: Films/Create
        public ActionResult Create()
        {
            ViewBag.ActorID = new SelectList(db.Actors, "ActorID", "ActorName");
            ViewBag.DirectorID = new SelectList(db.Directors, "DirectorID", "DirectorName");
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreType");
            return View();
        }

        // POST: Films/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FilmID,ActorID,DirectorID,GenreID,FilmName,ReleaseDate,Rating,Runtime,Studio")] Film film)
        {
            if (ModelState.IsValid)
            {
               // film.user = user.identity.GetUserId();
                db.Films.Add(film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ActorID = new SelectList(db.Actors, "ActorID", "ActorName", film.ActorID);
            ViewBag.DirectorID = new SelectList(db.Directors, "DirectorID", "DirectorName", film.DirectorID);
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreType", film.GenreID);
            return View(film);
        }

        // GET: Films/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            ViewBag.ActorID = new SelectList(db.Actors, "ActorID", "ActorName", film.ActorID);
            ViewBag.DirectorID = new SelectList(db.Directors, "DirectorID", "DirectorName", film.DirectorID);
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreType", film.GenreID);
            return View(film);
        }

        // POST: Films/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FilmID,ActorID,DirectorID,GenreID,FilmName,ReleaseDate,Rating,Runtime,Studio")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Entry(film).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ActorID = new SelectList(db.Actors, "ActorID", "ActorName", film.ActorID);
            ViewBag.DirectorID = new SelectList(db.Directors, "DirectorID", "DirectorName", film.DirectorID);
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreType", film.GenreID);
            return View(film);
        }

        // GET: Films/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Films/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Film film = db.Films.Find(id);
            db.Films.Remove(film);
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
