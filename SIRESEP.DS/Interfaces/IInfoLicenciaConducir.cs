using SIRESEP.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DS.Interfaces
{
    public interface IInfoLicenciaConducir
    {
        List<tbInfoLicenciaConducir> ListarInfoLicenciaConducir();
        tbInfoLicenciaConducir BuscarInfoLicenciaConducir(int idInfoLicenciaConducir);
        void InsertarInfoLicenciaConducir(tbInfoLicenciaConducir tbinfoLicenciaConducir);
        void ActualizarInfoLicenciaConducir(tbInfoLicenciaConducir tbinfoLicenciaConducir);
        void EliminarInfoLicenciaConducir(int idInfoLicenciaConducir);
    }
}
