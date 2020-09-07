using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTienda.Models.Request.Concret
{
    public class RolRequest : IEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}