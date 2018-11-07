using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIRESEP.DATOS;
using SIRESEP.DS.Interfaces;
using SIRESEP.DS.Metodos;

namespace SIRESEP.UI.Controllers
{
    public class CarreraController : Controller
    {
        private ICarrera carr;
        public CarreraController()
        {
            if (carr == null)
                carr = new MCarrera();
        }
        // GET: Carrera
        public ActionResult Index()
        {
            var carreras = carr.ListarCarrera();
            return View(carreras);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tbCarrera tbcarrera)
        {
            if (ModelState.IsValid)
            {
                carr.InsertarCarrera(tbcarrera);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
           var carreraBuscar = carr.BuscarCarrera(id);
        
            return View(carreraBuscar);
        }

        public ActionResult Edit(int id)
        {
            var carreraBuscar = carr.BuscarCarrera(id);
            
            return View(carreraBuscar);
        }
        [HttpPost]
        public ActionResult Edit(tbCarrera tbcarrera)
        {
           
            carr.ActualizarCarrera(tbcarrera);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            carr.EliminarCarrera(id);
            return RedirectToAction("Index");
        }
    }
}