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
    
    public partial class PermisosRol
    {
        public int Id { get; set; }
        public int Id_Permiso { get; set; }
        public int Id_Rol { get; set; }
    
        public virtual Permiso Permiso { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
