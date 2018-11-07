using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SIRESEP.DATOS
{
    public class tbInfoLaboral
    {
        public int idInfoLaboral { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "La carrera es requerida")]
        [StringLength(10, ErrorMessage = "La carrera no debe poseer mas de 15 caracteres")]
        public string profesion { get; set; }
        public int tiempoExperiencia { get; set; }
    }
}
