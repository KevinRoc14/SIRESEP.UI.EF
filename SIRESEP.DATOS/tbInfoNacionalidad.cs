using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SIRESEP.DATOS
{
    public class tbInfoNacionalidad
    {
        public int idNacionalidad { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "La Nacionalidad es requerida")]
        public string nacionalidad { get; set; }
    }
}
