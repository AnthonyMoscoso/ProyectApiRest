using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaDesktop.Models;
using TiendaDesktop.Models.Abstractas;

namespace ApiTienda.Models.Request.Concret
{
    public class Rol : IEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<Permiso> Permisos { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}