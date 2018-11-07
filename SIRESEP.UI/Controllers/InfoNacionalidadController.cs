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
    public class InfoNacionalidadController : Controller
    {
        private IInfoNacionalidad nacional;
        public InfoNacionalidadController()
        {
            if (nacional == null)
                nacional = new MInfoNacionalidad();
        }
        // GET: InfoNacionalidad
        public ActionResult Index()
        {
            var nacionalidades = nacional.ListarInfoNacionalidad();
            return View(nacionalidades);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tbInfoNacionalidad tbnacional)
        {
            if (ModelState.IsValid)
            {
                nacional.InsertarInfoNacionalidad(tbnacional);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var nacionalBuscar = nacional.BuscarInfoNacionalidad(id);

            return View(nacionalBuscar);
        }

        public ActionResult Edit(int id)
        {
            var nacionalBuscar = nacional.BuscarInfoNacionalidad(id);

            return View(nacionalBuscar);
        }
        [HttpPost]
        public ActionResult Edit(tbInfoNacionalidad tbnacional)
        {

            nacional.ActualizarInfoNacionalidad(tbnacional);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            nacional.EliminarInfoNacionalidad(id);
            return RedirectToAction("Index");
        }
    }
}