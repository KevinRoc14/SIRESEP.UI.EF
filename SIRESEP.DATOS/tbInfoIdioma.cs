using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SIRESEP.DATOS
{
    public class tbInfoIdioma
    {
        public int idIdioma { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Idioma es requerido")]
        public string idioma { get; set; }

    }
}
