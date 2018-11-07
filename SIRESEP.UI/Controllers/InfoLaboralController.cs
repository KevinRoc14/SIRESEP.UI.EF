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
    public class InfoLaboralController : Controller
    {
        private IInfoLaboral labor;

        public InfoLaboralController()
        {
            if (labor == null)
                labor = new MInfoLaboral();
        }
        // GET: InfoLaboral
        public ActionResult Index()
        {
            var labores = labor.ListarInfoLaboral();
            return View(labores);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tbInfoLaboral tblaboral)
        {
            if (ModelState.IsValid)
            {
                labor.InsertarInfoLaboral(tblaboral);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var laboralBuscar = labor.BuscarInfoLaboral(id);

            return View(laboralBuscar);
        }

        public ActionResult Edit(int id)
        {
            var laboralBuscar = labor.BuscarInfoLaboral(id);

            return View(laboralBuscar);
        }
        [HttpPost]
        public ActionResult Edit(tbInfoLaboral tblaboral)
        {

            labor.ActualizarInfoLaboral(tblaboral);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            labor.EliminarInfoLaboral(id);
            return RedirectToAction("Index");
        }
    }
}