using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SIRESEP.DATOS
{
   public class tbInfoGradoEstudio
    {
        public int idGradoEstudio { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "el Grado es requerido")]
        public string descripcion { get; set; }
    }
}
