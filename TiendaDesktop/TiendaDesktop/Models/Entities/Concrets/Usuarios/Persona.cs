using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaDesktop.Models;
using TiendaDesktop.Models.Abstractas;

namespace ApiTienda.Models.Request.Abstract
{
    public class Persona : IEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Username { get; set; }
        public string Contraseña { get; set; }
        public int Id_Direccion { get
            {
                return Direccion != null ? Direccion.Id : IdDir;
            }
            set { IdDir=value; }
        }

        private int IdDir;
        public Direccion Direccion { get; set; }
        public int Tipo { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

    }
}