using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DS.Interfaces;
using SIRESEP.DATOS;
namespace SIRESEP.DS.Metodos
{
    public class MInfoGenero : IInfoGenero
    {
        private InfoGenero MapearBD(tbInfoGenero tbinfoGenero)
        {
            return new InfoGenero()
            {
                idGenero = tbinfoGenero.idGenero,
                genero = tbinfoGenero.genero,
            };
        }
        private tbInfoGenero MapearAplicacion(InfoGenero infog)
        {
            return new tbInfoGenero()
            {
               idGenero = infog.idGenero,
               genero = infog.genero,
            };
        }

        public void ActualizarInfoGenero(tbInfoGenero tbinfogenero)
        {
            //solo se ponen los datos que se pueden editar
            using (var db = new BD_SIRESEPEntities1())
            {
                var editar = db.InfoGenero.Find(tbinfogenero.idGenero);
                editar.genero = tbinfogenero.genero;
                db.SaveChanges();
            }
        }

        public tbInfoGenero BuscarInfoGenero(int idGenero)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return MapearAplicacion(db.InfoGenero.Find(idGenero));
            }
        }

        public void EliminarInfoGenero(int idGenero)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var eliminar = db.InfoGenero.Find(idGenero);
                db.InfoGenero.Remove(eliminar);
                db.SaveChanges();
            }
        }

        public void InsertarInfoGenero(tbInfoGenero tbinfogenero)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                db.InfoGenero.Add(MapearBD(tbinfogenero));
                db.SaveChanges();
            }
        }

        public List<tbInfoGenero> ListarInfoGenero()
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return db.InfoGenero.Select(MapearAplicacion).ToList();
            }
        }
    }
}
