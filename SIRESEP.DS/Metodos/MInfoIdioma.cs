using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DS.Interfaces;
using SIRESEP.DATOS;
namespace SIRESEP.DS.Metodos
{
    public class MInfoIdioma : IInfoIdioma
    {
        private InfoIdioma MapearBD(tbInfoIdioma tbinfoI)
        {
            return new InfoIdioma()
            {
                idIdioma = tbinfoI.idIdioma,
                idioma = tbinfoI.idioma,
            };
        }
        private tbInfoIdioma MapearAplicacion(InfoIdioma infoidioma)
        {
            return new tbInfoIdioma()
            {
                idIdioma = infoidioma.idIdioma,
                idioma = infoidioma.idioma,
            };
        }
        public void ActualizarInfoIdioma(tbInfoIdioma tbinfoIdioma)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var editar = db.InfoIdioma.Find(tbinfoIdioma.idIdioma);
                //solo se ponen los datos que se pueden editar
                editar.idioma = tbinfoIdioma.idioma;
                db.SaveChanges();
            }
        }

        public tbInfoIdioma BuscarInfoIdioma(int idInfoIdioma)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return MapearAplicacion(db.InfoIdioma.Find(idInfoIdioma));
            }
            
        }

        public void EliminarInfoIdioma(int idInfoIdioma)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var eliminar = db.InfoIdioma.Find(idInfoIdioma);
                db.InfoIdioma.Remove(eliminar);
                db.SaveChanges();
            }
        }

        public void InsertarInfoIdioma(tbInfoIdioma tbinfoIdioma)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                db.InfoIdioma.Add(MapearBD(tbinfoIdioma));
                db.SaveChanges();
            }
        }

        public List<tbInfoIdioma> ListarInfoIdioma()
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return db.InfoIdioma.Select(MapearAplicacion).ToList();
            }
        }
    }
}
