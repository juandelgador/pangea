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
    
    public partial class Sucursal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sucursal()
        {
            this.Trabajador = new HashSet<Trabajador>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public bool habilitado { get; set; }
        public int id_trabajador_crea { get; set; }
        public System.DateTime fecha_crea { get; set; }
        public int id_trabajador_modif { get; set; }
        public System.DateTime fecha_modif { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trabajador> Trabajador { get; set; }
    }
}
