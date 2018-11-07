using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DS.Interfaces;
using SIRESEP.DATOS;
namespace SIRESEP.DS.Metodos
{
    public class MInfoLicenciaConducir : IInfoLicenciaConducir
    {
        /*estos dos metodos son mapeos a bd - aplicacion, sirve de traduccion ya que si no se hace esto no hay comunicacion entre la 
        la base y la aplicacion*/
        private InfoLicenciaConducir MapearBD(tbInfoLicenciaConducir tblicencia)
        {
            return new InfoLicenciaConducir()
            {
                idLicenciaConducir= tblicencia.idLicenciaConducir,
                licencia = tblicencia.licencia,
            };
        }
        private tbInfoLicenciaConducir MapearAplicacion(InfoLicenciaConducir lic)
        {
            return new tbInfoLicenciaConducir()
            {
                idLicenciaConducir = lic.idLicenciaConducir,
                licencia = lic.licencia,
            };
        }
        public void ActualizarInfoLicenciaConducir(tbInfoLicenciaConducir tbinfoLicenciaConducir)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var editar = db.InfoLicenciaConducir.Find(tbinfoLicenciaConducir.idLicenciaConducir);
                //solo se ponen los datos que se pueden editar
                editar.licencia = tbinfoLicenciaConducir.licencia;
                db.SaveChanges();
            }
        }

        public tbInfoLicenciaConducir BuscarInfoLicenciaConducir(int idInfoLicenciaConducir)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return MapearAplicacion(db.InfoLicenciaConducir.Find(idInfoLicenciaConducir));
            }
        }

        public void EliminarInfoLicenciaConducir(int idInfoLicenciaConducir)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var eliminar = db.InfoLicenciaConducir.Find(idInfoLicenciaConducir);
                db.InfoLicenciaConducir.Remove(eliminar);
                db.SaveChanges();
            }
         
        }

        public void InsertarInfoLicenciaConducir(tbInfoLicenciaConducir tbinfoLicenciaConducir)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                db.InfoLicenciaConducir.Add(MapearBD(tbinfoLicenciaConducir));
                db.SaveChanges();
            }
        }

        public List<tbInfoLicenciaConducir> ListarInfoLicenciaConducir()
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return db.InfoLicenciaConducir.Select(MapearAplicacion).ToList();
            }
        }
    }
}
