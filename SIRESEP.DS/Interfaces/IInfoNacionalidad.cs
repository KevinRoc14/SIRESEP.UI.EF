using SIRESEP.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DS.Interfaces
{
    public interface IInfoNacionalidad
    {
        List<tbInfoNacionalidad> ListarInfoNacionalidad();
        tbInfoNacionalidad BuscarInfoNacionalidad(int idInfoNacionalidad);
        void InsertarInfoNacionalidad(tbInfoNacionalidad tbinfoNacionalidad);
        void ActualizarInfoNacionalidad(tbInfoNacionalidad tbinfoNacionalidad);
        void EliminarInfoNacionalidad(int idInfoNacionalidad);
    }
}
