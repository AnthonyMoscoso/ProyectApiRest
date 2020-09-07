using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaDesktop.Models;
using TiendaDesktop.Models.Abstractas;

namespace ApiTienda.Models.Request.Concret
{
    public class PermisosRol : IEntidad
    {
        public int Id { get; set; }
        public int Id_Permiso { get; set; }
        public int Id_Rol { get; set; }
    }
}