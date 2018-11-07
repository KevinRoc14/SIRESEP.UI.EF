using SIRESEP.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DS.Interfaces
{
    public interface IInfoLaboral
    {
        List<tbInfoLaboral> ListarInfoLaboral();
        tbInfoLaboral BuscarInfoLaboral(int idInfoLaboral);
        void InsertarInfoLaboral(tbInfoLaboral tbinfoLaboral);
        void ActualizarInfoLaboral(tbInfoLaboral tbinfoLaboral);
        void EliminarInfoLaboral(int idInfoLaboral);
    }
}
