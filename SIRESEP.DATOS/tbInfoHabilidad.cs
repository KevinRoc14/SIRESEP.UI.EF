using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SIRESEP.DATOS
{
    public class tbInfoHabilidad
    {
        public int idHabilidad { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "la habilidad es requerida")]
        [StringLength(20, ErrorMessage = "La habilidad no puede tener mas de 20 caracteres")]
        public string habilidad { get; set; }
    }
}
