//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiTienda.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public int Id_Persona { get; set; }
        public decimal Descuento { get; set; }
        public System.DateTime Fecha_Alta { get; set; }
        public Nullable<System.DateTime> Fecha_Baja { get; set; }
    
        public virtual Persona Persona { get; set; }
    }
}
