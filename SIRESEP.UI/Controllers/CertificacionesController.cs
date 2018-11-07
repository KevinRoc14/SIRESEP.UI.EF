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
    public class CertificacionesController : Controller
    {
        private ICertificaciones cert;
        public CertificacionesController()
        {
            if (cert == null)
                cert = new MCertificacion();
        }
        // GET: Certificaciones
        public ActionResult Index()
        {
            var certificaciones = cert.ListarCertificaciones();
            return View(certificaciones);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tbCertificaciones tbcertificacion)
        {
            if (ModelState.IsValid)
            {
                cert.InsertarCertificacion(tbcertificacion);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var certificacionBuscar = cert.BuscarCertificacion(id);

            return View(certificacionBuscar);
        }
        public ActionResult Edit(int id)
        {
            var certificacionBuscar = cert.BuscarCertificacion(id);

            return View(certificacionBuscar);
        }
        [HttpPost]
        public ActionResult Edit(tbCertificaciones tbcertificacion)
        {

            cert.ActualizarCertificacion(tbcertificacion);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            cert.EliminarCertificacion(id);
            return RedirectToAction("Index");
        }
    }
}