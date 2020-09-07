using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTienda.Models.Request.Concret
{
    public class PermisosRolRequest :IEntity
    {
        public int Id { get; set; }
        public int Id_Permiso { get; set; }
        public int Id_Rol { get; set; }
    }
}