using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;
namespace SIRESEP.DS.Interfaces
{
    public interface IInfoHabilidades
    {
        List<tbInfoHabilidad> ListarHabilidades();
        tbInfoHabilidad BuscarHabilidad(int idHabilidad);
        void InsertarHabilidad(tbInfoHabilidad tbhabilidad);
        void ActualizarHabilidad(tbInfoHabilidad tbhabilidad);
        void EliminarHabilidad(int idHabilidad);
    }
}
