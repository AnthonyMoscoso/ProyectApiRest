using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace ApiTienda.Models.Request.Abstract
{
    public class Empleado  : Persona
    {
        public int Id_Persona { get; set; }
        public string Dni { get; set; }

        public Rol Rol { get; set; }
        public decimal Descuento
        {
            get
            {
                return 15;
            }     
        }
        public int Id_Rol { get 
            { return Rol != null ? Rol.Id : IdRol; } 
            set
            {
                IdRol = value;
            } }

        private int IdRol;
        public DateTime Fecha_Contratacion { get; set; }
        public DateTime? Fecha_Despido { get; set; }

    }
}