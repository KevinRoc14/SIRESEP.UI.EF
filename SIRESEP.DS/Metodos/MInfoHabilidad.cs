using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DS.Interfaces;
using SIRESEP.DATOS;
namespace SIRESEP.DS.Metodos
{
    public class MInfoHabilidad : IInfoHabilidades
    {
        /*estos dos metodos son mapeos a bd - aplicacion, sirve de traduccion ya que si no se hace esto no hay comunicacion entre la 
        la base y la aplicacion*/
        private InfoHabilidad MapearBD(tbInfoHabilidad tbinfoH)
        {
            return new InfoHabilidad()
            {
                idHabilidad = tbinfoH.idHabilidad,
                habilidad = tbinfoH.habilidad,
            };
        }
        private tbInfoHabilidad MapearAplicacion(InfoHabilidad infoH)
        {
            return new tbInfoHabilidad()
            {
                idHabilidad = infoH.idHabilidad,
                habilidad = infoH.habilidad,
            };
        }


        public void ActualizarHabilidad(tbInfoHabilidad tbhabilidad)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var editar = db.InfoHabilidad.Find(tbhabilidad.idHabilidad);
                //solo se ponen los datos que se pueden editar
                editar.habilidad = tbhabilidad.habilidad;
                db.SaveChanges();
            }
        }

        public tbInfoHabilidad BuscarHabilidad(int idHabilidad)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return MapearAplicacion(db.InfoHabilidad.Find(idHabilidad));
            }
        }

        public void EliminarHabilidad(int idHabilidad)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var eliminar = db.InfoHabilidad.Find(idHabilidad);
                db.InfoHabilidad.Remove(eliminar);
                db.SaveChanges();
            }
        }

        public void InsertarHabilidad(tbInfoHabilidad tbhabilidad)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                db.InfoHabilidad.Add(MapearBD(tbhabilidad));
                db.SaveChanges();
            }
        }

        public List<tbInfoHabilidad> ListarHabilidades()
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return db.InfoHabilidad.Select(MapearAplicacion).ToList();
            }
        }
    }
}
