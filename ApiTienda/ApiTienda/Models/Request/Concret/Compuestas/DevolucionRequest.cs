using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTienda.Models.Request.Concret
{
    public class DevolucionRequest : IEntity
    {
        public int Id { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public int Id_LineaCompra { get; set; }

        public virtual LineaCompra LineaCompra { get; set; }
    }
}