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
    public class InfoLicenciaConducirController : Controller
    {
        private IInfoLicenciaConducir licen;

        public InfoLicenciaConducirController()
        {
            if (licen == null)
                licen = new MInfoLicenciaConducir();
        }
        // GET: InfoLicenciaConducir
        public ActionResult Index()
        {
            var licencias = licen.ListarInfoLicenciaConducir();
            return View(licencias);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tbInfoLicenciaConducir tblicencias)
        {
            if (ModelState.IsValid)
            {
                licen.InsertarInfoLicenciaConducir(tblicencias);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var licenciasBuscar = licen.BuscarInfoLicenciaConducir(id);

            return View(licenciasBuscar);
        }

        public ActionResult Edit(int id)
        {
            var licenciasBuscar = licen.BuscarInfoLicenciaConducir(id);

            return View(licenciasBuscar);
        }
        [HttpPost]
        public ActionResult Edit(tbInfoLicenciaConducir tblicencias)
        {

            licen.ActualizarInfoLicenciaConducir(tblicencias);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            licen.EliminarInfoLicenciaConducir(id);
            return RedirectToAction("Index");
        }
    }
}