//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIRESEP.DS
{
    using System;
    using System.Collections.Generic;
    
    public partial class InfoAdicional
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfoAdicional()
        {
            this.infoAdicional_perfilProfesional = new HashSet<infoAdicional_perfilProfesional>();
        }
    
        public int idInfoAdicional { get; set; }
        public Nullable<int> idIdioma { get; set; }
        public string nivelIdioma { get; set; }
        public Nullable<int> idLicenciaConducir { get; set; }
    
        public virtual InfoIdioma InfoIdioma { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<infoAdicional_perfilProfesional> infoAdicional_perfilProfesional { get; set; }
        public virtual InfoLicenciaConducir InfoLicenciaConducir { get; set; }
    }
}
