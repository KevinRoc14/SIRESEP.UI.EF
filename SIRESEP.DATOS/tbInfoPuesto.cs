using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SIRESEP.DATOS
{
    public class tbInfoPuesto
    {
        public int idPuesto { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "el puesto es requerido")]
        public string puesto { get; set; }
    }
}
