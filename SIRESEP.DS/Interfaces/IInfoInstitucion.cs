using SIRESEP.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DS.Interfaces
{
    public interface IInfoInstitucion
    {
        List<tbInfoInstitucion> ListarInfoInstitucion();
        tbInfoInstitucion BuscarInfoInstitucion(int idInfoInstitucion);
        void InsertarInfoInstitucion(tbInfoInstitucion tbinfoInstitucion);
        void ActualizarInfoInstitucion(tbInfoInstitucion tbinfoInstitucion);
        void EliminarInfoInstitucion(int idInfoInstitucion);
    }
}
