using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SIRESEP.DATOS
{
    public class tbInfoGenero
    {
        public int idGenero { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "el genero es requerido")]
        [StringLength(10, ErrorMessage = "El genero no puede tener mas de 10 caracteres")]
        public string genero { get; set; }
    }
}
