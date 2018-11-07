using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;

namespace SIRESEP.DS.Interfaces
{
    public interface IInfoPuesto
    {
        List<tbInfoPuesto> ListarInfoPuesto();
        tbInfoPuesto BuscarInfoPuesto(int idPuesto);
        void InsertarInfoPuesto(tbInfoPuesto tbinfopuesto);
        void ActualizarInfoPuesto(tbInfoPuesto tbinfopuesto);
        void EliminarInfoPuesto(int idPuesto);
    }
}
