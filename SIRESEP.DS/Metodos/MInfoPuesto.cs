using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DS.Interfaces;
using SIRESEP.DATOS;
namespace SIRESEP.DS.Metodos
{
    public class MInfoPuesto : IInfoPuesto
    {
        /*estos dos metodos son mapeos a bd - aplicacion, sirve de traduccion ya que si no se hace esto no hay comunicacion entre la 
        la base y la aplicacion*/
        private InfoPuesto MapearBD(tbInfoPuesto tbpuesto)
        {
            return new InfoPuesto()
            {
              idPuesto = tbpuesto.idPuesto,
              puesto = tbpuesto.puesto,
            };
        }
        private tbInfoPuesto MapearAplicacion(InfoPuesto puest)
        {
            return new tbInfoPuesto()
            {
                idPuesto = puest.idPuesto,
                puesto = puest.puesto,
            };
        }
        public void ActualizarInfoPuesto(tbInfoPuesto tbinfopuesto)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var editar = db.InfoPuesto.Find(tbinfopuesto.idPuesto);
                //solo se ponen los datos que se pueden editar
                editar.puesto = tbinfopuesto.puesto;
                db.SaveChanges();
            }
        }

        public tbInfoPuesto BuscarInfoPuesto(int idPuesto)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return MapearAplicacion(db.InfoPuesto.Find(idPuesto));
            }
        }

        public void EliminarInfoPuesto(int idPuesto)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var eliminar = db.InfoPuesto.Find(idPuesto);
                db.InfoPuesto.Remove(eliminar);
                db.SaveChanges();
            }
        }

        public void InsertarInfoPuesto(tbInfoPuesto tbinfopuesto)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                db.InfoPuesto.Add(MapearBD(tbinfopuesto));
                db.SaveChanges();
            }
           
        }

        public List<tbInfoPuesto> ListarInfoPuesto()
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return db.InfoPuesto.Select(MapearAplicacion).ToList();
            }
           
        }
    }
}
