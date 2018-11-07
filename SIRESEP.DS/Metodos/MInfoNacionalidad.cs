using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DS.Interfaces;
using SIRESEP.DATOS;
namespace SIRESEP.DS.Metodos
{
    public class MInfoNacionalidad : IInfoNacionalidad
    {
        /*estos dos metodos son mapeos a bd - aplicacion, sirve de traduccion ya que si no se hace esto no hay comunicacion entre la 
         la base y la aplicacion*/
        private InfoNacionalidad MapearBD(tbInfoNacionalidad tbinfoNa)
        {
            return new InfoNacionalidad()
            {
                idNacionalidad = tbinfoNa.idNacionalidad,
                nacionalidad = tbinfoNa.nacionalidad,
            };
        }
        private tbInfoNacionalidad MapearAplicacion(InfoNacionalidad infoNa)
        {
            return new tbInfoNacionalidad()
            {
                idNacionalidad = infoNa.idNacionalidad,
                nacionalidad = infoNa.nacionalidad,
            };
        }
        public void ActualizarInfoNacionalidad(tbInfoNacionalidad tbinfoNacionalidad)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var editar = db.InfoNacionalidad.Find(tbinfoNacionalidad.idNacionalidad);
                //solo se ponen los datos que se pueden editar
                editar.nacionalidad = tbinfoNacionalidad.nacionalidad;
                db.SaveChanges();
            }
        }

        public tbInfoNacionalidad BuscarInfoNacionalidad(int idInfoNacionalidad)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return MapearAplicacion(db.InfoNacionalidad.Find(idInfoNacionalidad));
            }
        }

        public void EliminarInfoNacionalidad(int idInfoNacionalidad)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var eliminar = db.InfoNacionalidad.Find(idInfoNacionalidad);
                db.InfoNacionalidad.Remove(eliminar);
                db.SaveChanges();
            }
        }

        public void InsertarInfoNacionalidad(tbInfoNacionalidad tbinfoNacionalidad)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                db.InfoNacionalidad.Add(MapearBD(tbinfoNacionalidad));
                db.SaveChanges();
            }
        }

        public List<tbInfoNacionalidad> ListarInfoNacionalidad()
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return db.InfoNacionalidad.Select(MapearAplicacion).ToList();
            }
        }
    }
}
