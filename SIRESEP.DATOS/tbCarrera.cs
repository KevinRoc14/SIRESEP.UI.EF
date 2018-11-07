using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SIRESEP.DATOS
{
    public class  tbCarrera
    {

        public int idCarrera { get; set; }
        [Display(Name = "Carrera")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "La carrera es requerida")]
        [StringLength(10, ErrorMessage = "La carrera no debe poseer mas de 15 caracteres")]
        public string carrera { get; set; }

    }
}
