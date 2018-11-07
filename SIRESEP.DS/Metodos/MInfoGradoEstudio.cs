using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DS.Interfaces;
using SIRESEP.DATOS;
namespace SIRESEP.DS.Metodos
{
    public class MInfoGradoEstudio : IInfoGradoEstudio
    {
        private InfoGradoEstudio MapearBD(tbInfoGradoEstudio tbinfoGrado)
        {
            return new InfoGradoEstudio()
            {
                idGradoEstudio = tbinfoGrado.idGradoEstudio,
                descripcion = tbinfoGrado.descripcion,
            };
        }
        private tbInfoGradoEstudio MapearAplicacion(InfoGradoEstudio infoge)
        {
            return new tbInfoGradoEstudio()
            {
                idGradoEstudio = infoge.idGradoEstudio,
                descripcion = infoge.descripcion,
            };
        }
        public void ActualizarGradoEstudio(tbInfoGradoEstudio tbgradoestudio)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var editar = db.InfoGradoEstudio.Find(tbgradoestudio.idGradoEstudio);
                //solo se ponen los datos que se pueden editar
                editar.descripcion = tbgradoestudio.descripcion;
                db.SaveChanges();
            }
           
        }

        public tbInfoGradoEstudio BuscarGradoEstudio(int idGradoEstudio)
        {

            using (var db = new BD_SIRESEPEntities1())
            {
                return MapearAplicacion(db.InfoGradoEstudio.Find(idGradoEstudio));
            }
        }

        public void EliminarGradoEstudio(int idGradoEstudio)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                var eliminar = db.InfoGradoEstudio.Find(idGradoEstudio);
                db.InfoGradoEstudio.Remove(eliminar);
                db.SaveChanges();
            }
        }

        public void InsertarGradoEstudio(tbInfoGradoEstudio tbgradoestudio)
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                db.InfoGradoEstudio.Add(MapearBD(tbgradoestudio));
                db.SaveChanges();
            }
        }

        public List<tbInfoGradoEstudio> ListarGradoEstudio()
        {
            using (var db = new BD_SIRESEPEntities1())
            {
                return db.InfoGradoEstudio.Select(MapearAplicacion).ToList();
            }
        }
    }
}
