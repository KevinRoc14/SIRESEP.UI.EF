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
    
    public partial class perfilProfesional_PerfilConcurso
    {
        public int idMatch { get; set; }
        public Nullable<int> idConcurso { get; set; }
        public Nullable<int> idPerfilProfesional { get; set; }
        public string usuarioCrea { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public string usuarioModifica { get; set; }
        public Nullable<System.DateTime> fechaModifica { get; set; }
    
        public virtual PerfilDelConcurso PerfilDelConcurso { get; set; }
        public virtual PerfilPersona PerfilPersona { get; set; }
    }
}