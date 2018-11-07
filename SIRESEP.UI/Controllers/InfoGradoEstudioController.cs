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
    public class InfoGradoEstudioController : Controller
    {
        private IInfoGradoEstudio grado;
        public InfoGradoEstudioController()
        {
            if (grado == null)
                grado = new MInfoGradoEstudio();
        }
        // GET: InfoGradoEstudio
        public ActionResult Index()
        {
            var grados = grado.ListarGradoEstudio();
            return View(grados);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tbInfoGradoEstudio tbgrado)
        {
            if (ModelState.IsValid)
            {
                grado.InsertarGradoEstudio(tbgrado);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var gradoBuscar = grado.BuscarGradoEstudio(id);

            return View(gradoBuscar);
        }
        public ActionResult Edit(int id)
        {
            var gradoBuscar = grado.BuscarGradoEstudio(id);

            return View(gradoBuscar);
        }
        [HttpPost]
        public ActionResult Edit(tbInfoGradoEstudio tbgrado)
        {

            grado.ActualizarGradoEstudio(tbgrado);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            grado.EliminarGradoEstudio(id);
            return RedirectToAction("Index");
        }
    }
}