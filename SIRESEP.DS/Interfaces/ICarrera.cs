using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;

namespace SIRESEP.DS.Interfaces
{
    public interface ICarrera
    {
        List<tbCarrera> ListarCarrera();
        tbCarrera BuscarCarrera(int idCarrera);
        void InsertarCarrera(tbCarrera tbcarrera);
        void ActualizarCarrera(tbCarrera tbcarrera);
        void EliminarCarrera(int idCarrera);
    }
}
