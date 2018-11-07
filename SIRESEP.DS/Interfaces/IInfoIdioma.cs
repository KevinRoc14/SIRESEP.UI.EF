using SIRESEP.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DS.Interfaces
{
    public interface IInfoIdioma
    {
        List<tbInfoIdioma> ListarInfoIdioma();
        tbInfoIdioma BuscarInfoIdioma(int idInfoIdioma);
        void InsertarInfoIdioma(tbInfoIdioma tbinfoIdioma);
        void ActualizarInfoIdioma(tbInfoIdioma tbinfoIdioma);
        void EliminarInfoIdioma(int idInfoIdioma);
    }
}
