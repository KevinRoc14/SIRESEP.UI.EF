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
    public class InfoGeneroController : Controller
    {
        private IInfoGenero infog;
        public InfoGeneroController()
        {
            if (infog == null)
                infog = new MInfoGenero();
        }
        // GET: InfoGenero
        public ActionResult Index()
        {
            var generos = infog.ListarInfoGenero();
            return View(generos);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tbInfoGenero tbgenero)
        {
            if (ModelState.IsValid)
            {
                infog.InsertarInfoGenero(tbgenero);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var generoBuscar = infog.BuscarInfoGenero(id);

            return View(generoBuscar);
        }
        public ActionResult Edit(int id)
        {
            var generoBuscar = infog.BuscarInfoGenero(id);

            return View(generoBuscar);
        }
        [HttpPost]
        public ActionResult Edit(tbInfoGenero tbgenero)
        {

            infog.ActualizarInfoGenero(tbgenero);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            infog.EliminarInfoGenero(id);
            return RedirectToAction("Index");
        }
    }
}