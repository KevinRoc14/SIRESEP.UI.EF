using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;
namespace SIRESEP.DS.Interfaces
{
    public interface IInfoGradoEstudio
    {
        List<tbInfoGradoEstudio> ListarGradoEstudio();
        tbInfoGradoEstudio BuscarGradoEstudio(int idGradoEstudio);
        void InsertarGradoEstudio(tbInfoGradoEstudio tbgradoestudio);
        void ActualizarGradoEstudio(tbInfoGradoEstudio tbgradoestudio);
        void EliminarGradoEstudio(int idGradoEstudio);
    }
}
