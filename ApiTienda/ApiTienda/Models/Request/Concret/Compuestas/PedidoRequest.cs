using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTienda.Models.Request.Concret
{
    public class PedidoRequest : IEntity
    {
        public int Id_Empleado { get; set; }
        public DateTime Fecha { get; set; }
        public int Id { get ; set ; }
    }
}