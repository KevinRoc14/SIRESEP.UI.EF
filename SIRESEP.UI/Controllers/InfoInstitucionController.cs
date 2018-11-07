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
    public class InfoInstitucionController : Controller
    {
        private IInfoInstitucion insti;
        public InfoInstitucionController()
        {
            if (insti == null)
                insti = new MInfoInstitucion();
        }
        // GET: InfoInstitucion
        public ActionResult Index()
        {
            var instituciones = insti.ListarInfoInstitucion();
            return View(instituciones);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tbInfoInstitucion tbinstitucion)
        {
            if (ModelState.IsValid)
            {
                insti.InsertarInfoInstitucion(tbinstitucion);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var institucionBuscar = insti.BuscarInfoInstitucion(id);

            return View(institucionBuscar);
        }

        public ActionResult Edit(int id)
        {
            var institucionBuscar = insti.BuscarInfoInstitucion(id);

            return View(institucionBuscar);
        }
        [HttpPost]
        public ActionResult Edit(tbInfoInstitucion tbinstitucion)
        {

            insti.ActualizarInfoInstitucion(tbinstitucion);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            insti.EliminarInfoInstitucion(id);
            return RedirectToAction("Index");
        }
    }
}