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
    public class InfoIdiomaController : Controller
    {
        private IInfoIdioma idiomm;
        public InfoIdiomaController()
        {
            if (idiomm == null)
                idiomm = new MInfoIdioma();
        }
        // GET: InfoIdioma
        public ActionResult Index()
        {
            var idiomas = idiomm.ListarInfoIdioma();
            return View(idiomas);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tbInfoIdioma tbidioma)
        {
            if (ModelState.IsValid)
            {
                idiomm.InsertarInfoIdioma(tbidioma);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var idiomaBuscar = idiomm.BuscarInfoIdioma(id);

            return View(idiomaBuscar);
        }
        public ActionResult Edit(int id)
        {
            var idiomaBuscar = idiomm.BuscarInfoIdioma(id);

            return View(idiomaBuscar);
        }
        [HttpPost]
        public ActionResult Edit(tbInfoIdioma tbidioma)
        {

            idiomm.ActualizarInfoIdioma(tbidioma);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            idiomm.EliminarInfoIdioma(id);
            return RedirectToAction("Index");
        }

    }
}