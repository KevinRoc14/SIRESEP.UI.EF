using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;
namespace SIRESEP.DS.Interfaces
{
    public interface IInfoGenero
    {
        List<tbInfoGenero> ListarInfoGenero();
        tbInfoGenero BuscarInfoGenero(int idGenero);
        void InsertarInfoGenero(tbInfoGenero tbinfogenero);
        void ActualizarInfoGenero(tbInfoGenero tbinfogenero);
        void EliminarInfoGenero(int idGenero);
    }
}
