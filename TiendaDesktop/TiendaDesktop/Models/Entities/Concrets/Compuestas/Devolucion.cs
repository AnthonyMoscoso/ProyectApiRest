using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaDesktop.Models;
using TiendaDesktop.Models.Abstractas;

namespace ApiTienda.Models.Request.Concret
{
    public class Devolucion : IEntidad
    {
        public int Id { get; set; }

        private int LineaId;
        public int Id_LineaCompra {
            get 
            {
                return LineaCompra != null ? LineaCompra.Id : LineaId;
            }
            set { LineaId = value; } }
        public LineaCompra LineaCompra { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        
    }
}