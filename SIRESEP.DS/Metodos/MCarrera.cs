using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DS.Interfaces;
using SIRESEP.DATOS;
namespace SIRESEP.DS.Metodos
{
    public class MCarrera : ICarrera
    {
        /*estos dos metodos son mapeos a bd - aplicacion, sirve de traduccion ya que si no se hace esto no hay comunicacion entre la 
        la base y la aplicacion*/
        private Carrera MapearBD(tbCarrera tbcarrera)
        {
            return new Carrera()
            {
                idCarrera = tbcarrera.idCarrera,
                carrera = tbcarrera.carrera,
            };
        }
        private tbCarrera MapearAplicacion(Carrera carr)
        {
            return new tbCarrera()
            {
                idCarrera = carr.idCarrera,
                carrera = carr.carrera,
            };
        }

        public void ActualizarCarrera(tbCarrera tbcarrera)
        {
            
            using (var db = new BD_SIRESEPEntities1())
            {
                var editar = db.Carrera.Find(tbcarrera.idCarrera);
                //solo se ponen los datos que se pueden editar
                editar.carrera = tbcarrera.carrera;
                db.SaveChanges();
            }

         }

        public tbCarrera BuscarCarrera(int idCarrera)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return MapearAplicacion(db.Carrera.Find(idCarrera));
            }
        }

        public void EliminarCarrera(int idCarrera)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var eliminar = db.Carrera.Find(idCarrera);
                db.Carrera.Remove(eliminar);
                db.SaveChanges();
            }
        }

        public void InsertarCarrera(tbCarrera tbcarrera)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                db.Carrera.Add(MapearBD(tbcarrera));
                db.SaveChanges();
            }
        }

        public List<tbCarrera> ListarCarrera()
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return db.Carrera.Select(MapearAplicacion).ToList();
            }
        }
    }
}
