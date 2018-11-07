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
    public class InfoHabilidadController : Controller
    {
        private IInfoHabilidades hab;
        public InfoHabilidadController()
        {
            if (hab == null)
                hab = new MInfoHabilidad();
        }
        // GET: InfoHabilidad
        public ActionResult Index()
        {
            var habilidades = hab.ListarHabilidades();
            return View(habilidades);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tbInfoHabilidad tbhabilidad)
        {
            if (ModelState.IsValid)
            {
                hab.InsertarHabilidad(tbhabilidad);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var habilidadBuscar = hab.BuscarHabilidad(id);

            return View(habilidadBuscar);
        }
        public ActionResult Edit(int id)
        {
            var habilidadBuscar = hab.BuscarHabilidad(id);

            return View(habilidadBuscar);
        }
        [HttpPost]
        public ActionResult Edit(tbInfoHabilidad tbhabilidad)
        {

            hab.ActualizarHabilidad(tbhabilidad);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            hab.EliminarHabilidad(id);
            return RedirectToAction("Index");
        }
    }
}