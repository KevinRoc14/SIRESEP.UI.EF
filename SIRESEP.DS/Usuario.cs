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
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Rol_Usuario = new HashSet<Rol_Usuario>();
        }
    
        public int idUsuario { get; set; }
        public string correoElectronico { get; set; }
        public string cedula { get; set; }
        public string contrasena { get; set; }
        public Nullable<System.DateTime> fechaRegistro { get; set; }
        public Nullable<int> idRol { get; set; }
        public Nullable<int> idEstado { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual Rol Rol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rol_Usuario> Rol_Usuario { get; set; }
    }
}
