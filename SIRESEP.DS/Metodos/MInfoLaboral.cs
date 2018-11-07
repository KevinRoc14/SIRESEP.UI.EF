using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DS.Interfaces;
using SIRESEP.DATOS;
namespace SIRESEP.DS.Metodos
{
    public class MInfoLaboral : IInfoLaboral
    {
        /*estos dos metodos son mapeos a bd - aplicacion, sirve de traduccion ya que si no se hace esto no hay comunicacion entre la 
       la base y la aplicacion*/
        private InfoLaboral MapearBD(tbInfoLaboral tbinfoLa)
        {
            return new InfoLaboral()
            {
                idInfoLaboral = tbinfoLa.idInfoLaboral,
                profesion = tbinfoLa.profesion,
                tiempoExperiencia = tbinfoLa.tiempoExperiencia,
            };
        }
        private tbInfoLaboral MapearAplicacion(InfoLaboral infoLa)
        {
            return new tbInfoLaboral()
            {
               idInfoLaboral = infoLa.idInfoLaboral,
               profesion = infoLa.profesion,
               tiempoExperiencia = infoLa.tiempoExperiencia,
            };
        }


        public void ActualizarInfoLaboral(tbInfoLaboral tbinfoLaboral)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var editar = db.InfoLaboral.Find(tbinfoLaboral.idInfoLaboral);
                //solo se ponen los datos que se pueden editar
                editar.profesion = tbinfoLaboral.profesion;
                editar.tiempoExperiencia = tbinfoLaboral.tiempoExperiencia;
                db.SaveChanges();
            }
        }

        public tbInfoLaboral BuscarInfoLaboral(int idInfoLaboral)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return MapearAplicacion(db.InfoLaboral.Find(idInfoLaboral));
            }
        }

        public void EliminarInfoLaboral(int idInfoLaboral)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var eliminar = db.InfoLaboral.Find(idInfoLaboral);
                db.InfoLaboral.Remove(eliminar);
                db.SaveChanges();
            }
        }

        public void InsertarInfoLaboral(tbInfoLaboral tbinfoLaboral)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                db.InfoLaboral.Add(MapearBD(tbinfoLaboral));
                db.SaveChanges();
            }
        }

        public List<tbInfoLaboral> ListarInfoLaboral()
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return db.InfoLaboral.Select(MapearAplicacion).ToList();
            }
        }
    }
}
