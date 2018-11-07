using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DS.Interfaces;
using SIRESEP.DATOS;
namespace SIRESEP.DS.Metodos
{
    public class MCertificacion : ICertificaciones
    {
        /*estos dos metodos son mapeos a bd - aplicacion, sirve de traduccion ya que si no se hace esto no hay comunicacion entre la 
        la base y la */
        private Certificaciones MapearBD(tbCertificaciones tbcerti)
        {
            return new Certificaciones()
            {
                idCertificacion = tbcerti.idCertificacion,
                nombre = tbcerti.nombre,
                ano = tbcerti.ano,

            };
        }
        private tbCertificaciones MapearAplicacion(Certificaciones cert)
        {
            return new tbCertificaciones()
            {
                idCertificacion = cert.idCertificacion,
                nombre = cert.nombre,
                ano = cert.ano,
            };
        }
        public void ActualizarCertificacion(tbCertificaciones tbcertificacion)
        {
            //solo se ponen los datos que se pueden editar
            using (var db = new BD_SIRESEPEntities1())
            {
                
                var editar = db.Certificaciones.Find(tbcertificacion.idCertificacion);
                editar.nombre = tbcertificacion.nombre;
                editar.ano = tbcertificacion.ano;
                db.SaveChanges();
            }
        }

        public tbCertificaciones BuscarCertificacion(int idCertificacion)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return MapearAplicacion(db.Certificaciones.Find(idCertificacion));
            }
        }

        public void EliminarCertificacion(int idCertificacion)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var eliminar = db.Certificaciones.Find(idCertificacion);
                db.Certificaciones.Remove(eliminar);
                db.SaveChanges();
            }
        }

        public void InsertarCertificacion(tbCertificaciones tbcertificacion)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                db.Certificaciones.Add(MapearBD(tbcertificacion));
                db.SaveChanges();
            }
        }

        public List<tbCertificaciones> ListarCertificaciones()
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return db.Certificaciones.Select(MapearAplicacion).ToList();
            }
        }
    }
}
