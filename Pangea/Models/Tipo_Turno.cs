//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pangea.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tipo_Turno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_Turno()
        {
            this.Turno = new HashSet<Turno>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public System.TimeSpan hora_inicio { get; set; }
        public System.TimeSpan hora_fin { get; set; }
        public bool habilitado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turno> Turno { get; set; }
    }
}
