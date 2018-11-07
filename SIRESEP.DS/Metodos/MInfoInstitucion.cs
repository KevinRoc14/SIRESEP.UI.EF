using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DS.Interfaces;
using SIRESEP.DATOS;
namespace SIRESEP.DS.Metodos
{
    public class MInfoInstitucion : IInfoInstitucion
    {
        private InfoInstitucion MapearBD(tbInfoInstitucion tbinfoIns)
        {
            return new InfoInstitucion()
            {
                idInstitucion = tbinfoIns.idInstitucion,
                nombreInstitucion = tbinfoIns.nombreInstitucion,
                ano = tbinfoIns.ano,
            };
        }
        private tbInfoInstitucion MapearAplicacion(InfoInstitucion infoIns)
        {
            return new tbInfoInstitucion()
            {
                idInstitucion = infoIns.idInstitucion,
                nombreInstitucion = infoIns.nombreInstitucion,
                ano = infoIns.ano,
            };
        }
        public void ActualizarInfoInstitucion(tbInfoInstitucion tbinfoInstitucion)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var editar = db.InfoInstitucion.Find(tbinfoInstitucion.idInstitucion);
                //solo se ponen los datos que se pueden editar
                editar.nombreInstitucion = tbinfoInstitucion.nombreInstitucion;
                editar.ano = tbinfoInstitucion.ano;
                db.SaveChanges();
            }
        }

        public tbInfoInstitucion BuscarInfoInstitucion(int idInfoInstitucion)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return MapearAplicacion(db.InfoInstitucion.Find(idInfoInstitucion));
            }
        }

        public void EliminarInfoInstitucion(int idInfoInstitucion)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var eliminar = db.InfoInstitucion.Find(idInfoInstitucion);
                db.InfoInstitucion.Remove(eliminar);
                db.SaveChanges();
            }
        }

        public void InsertarInfoInstitucion(tbInfoInstitucion tbinfoInstitucion)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                db.InfoInstitucion.Add(MapearBD(tbinfoInstitucion));
                db.SaveChanges();
            }
        }

        public List<tbInfoInstitucion> ListarInfoInstitucion()
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return db.InfoInstitucion.Select(MapearAplicacion).ToList();
            }
        }
    }
}
