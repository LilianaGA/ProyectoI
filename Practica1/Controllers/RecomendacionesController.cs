using EntityApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica1.Controllers
{
    public class RecomendacionesController : Controller
    {
        private RecomendacionesDb db = new RecomendacionesDb();
        //
        // GET: /Aulas/

        public ActionResult Index()
        {
            List<Recomendacion> recomendaciones = db.Recomendaciones.ToList();
            ViewBag.recomendaciones = recomendaciones;
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Aulas/Create

        [HttpPost]
        public ActionResult Create(string nombre = "", string telefono = "", string correo = "", string comentario = "")
        {
            Recomendacion nueva = new Recomendacion();
            nueva.id += 1;
            nueva.nombre = nombre;
            nueva.telefono = telefono;
            nueva.correo = correo;
            nueva.comentario = comentario;
            if (ModelState.IsValid)
            {
                db.Recomendaciones.Add(nueva);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id = 0)
        {
            Recomendacion reco = db.Recomendaciones.Find(id);
            if (reco == null)
            {
                return HttpNotFound();
            }
            ViewBag.aula = reco;
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
