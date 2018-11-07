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
    public class InfoPuestoController : Controller
    {
        private IInfoPuesto puest;
        public InfoPuestoController()
        {
            if (puest == null)
                puest = new MInfoPuesto();
        }
        // GET: InfoPuesto
        public ActionResult Index()
        {
            var puestos = puest.ListarInfoPuesto();
            return View(puestos);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tbInfoPuesto tbpuesto)
        {
            if (ModelState.IsValid)
            {
                puest.InsertarInfoPuesto(tbpuesto);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var puestoBuscar = puest.BuscarInfoPuesto(id);

            return View(puestoBuscar);
        }
        public ActionResult Edit(int id)
        {
            var puestoBuscar = puest.BuscarInfoPuesto(id);

            return View(puestoBuscar);
        }
        [HttpPost]
        public ActionResult Edit(tbInfoPuesto tbpuesto)
        {

            puest.ActualizarInfoPuesto(tbpuesto);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            puest.EliminarInfoPuesto(id);
            return RedirectToAction("Index");
        }
    }
}