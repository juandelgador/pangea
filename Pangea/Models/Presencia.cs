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
    
    public partial class Presencia
    {
        public int id { get; set; }
        public int id_turno { get; set; }
        public System.DateTime inicio { get; set; }
        public System.DateTime fin { get; set; }
        public int id_trabajador_crea { get; set; }
        public System.DateTime fecha_crea { get; set; }
    
        public virtual Turno Turno { get; set; }
    }
}