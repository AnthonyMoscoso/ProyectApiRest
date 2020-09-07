using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTienda.Models.Request.Abstract
{
    public class PersonaRequest : IEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Username { get; set; }
        public string Contraseña { get; set; }
        public int Id_Direccion { get; set; }
        public int Tipo { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

    }
}