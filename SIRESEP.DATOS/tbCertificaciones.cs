using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SIRESEP.DATOS
{
    public class tbCertificaciones
    {
        public int idCertificacion { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "el nombre es requerido")]
        public string nombre { get; set; }
        [Display(Name = "Año")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "el ano es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime ano { get; set; }
    }
}
