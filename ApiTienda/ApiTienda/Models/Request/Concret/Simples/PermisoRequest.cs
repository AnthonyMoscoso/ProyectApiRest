using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTienda.Models.Request.Abstract
{
    public class PermisoRequest :IEntity
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
    }
}