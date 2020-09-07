using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaDesktop.Models;
using TiendaDesktop.Models.Abstractas;

namespace ApiTienda.Models.Request.Abstract
{
    public class Permiso : IEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }


        public override string ToString()
        {
            return Nombre;
        }
    }
}