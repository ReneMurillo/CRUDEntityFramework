using CRUDAlumnoEF.Context;
using CRUDAlumnoEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CRUDAlumnoEF.Controllers
{
    public class AlumnosController : Controller
    {
        private AlumnoContext db = new AlumnoContext();
        // GET: Alumnos
        public ActionResult Index()
        {
            
            return View(db.Alumnos.ToList());
        }

        // GET: Alumnos/Details/5
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumnos.Find(id);
            if(alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // GET: Alumnos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Create(Alumno alumno)
        {
            if (ModelState.IsValid)
            { 
                // TODO: Add insert logic here
                db.Alumnos.Add(alumno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(alumno);
        }

        // GET: Alumnos/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Alumno alumno = db.Alumnos.Find(id);
            if(alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // POST: Alumnos/Edit/5
        [HttpPost]
        public ActionResult Edit(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alumno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(alumno);
        }

        // GET: Alumnos/Delete/5
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumnos.Find(id);
            if(alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            Alumno alumno = db.Alumnos.Find(id);
            db.Alumnos.Remove(alumno);
            try
            {
                db.SaveChanges();
            }
            catch(Exception ex)
            {

            }
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
