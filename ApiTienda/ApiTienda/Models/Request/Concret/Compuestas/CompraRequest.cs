using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTienda.Models.Request.Concret
{
    public class CompraRequest : IEntity
    {
        public int? Id_Comprador { get; set; }
        public int? Id_Vendedor { get; set; }
        public DateTime Fecha { get; set; }
        public int FormaPago { get; set; }
        public decimal Descuento { get; set; }
        public int Id { get; set ; }
    }
}