using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTienda.Models.Request.Abstract
{
    public class ProductoRequest : IEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public int Id_Categoria { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Descuento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int? Estado { get; set; }
        public int CantidadInventario { get; set; }
    }
}