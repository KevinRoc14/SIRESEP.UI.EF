using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DATOS;

namespace SIRESEP.DS.Interfaces
{
    public interface ICertificaciones
    {
        List<tbCertificaciones> ListarCertificaciones();
        tbCertificaciones BuscarCertificacion(int idCertificacion);
        void InsertarCertificacion(tbCertificaciones tbcertificacion);
        void ActualizarCertificacion(tbCertificaciones tbcertificacion);
        void EliminarCertificacion(int idCertificacion);

    }
}
