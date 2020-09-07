using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaDesktop.Models;
using TiendaDesktop.Models.Abstractas;

namespace ApiTienda.Models.Request.Concret
{
    public class LineaCompra : IEntidad
    {
        public int Id { get; set; }
        public int Id_Compra { get; set; }
        public int Id_Producto {
            get { return Producto != null ? Producto.Id : ProductoId; }
            set { ProductoId = value; } }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Descuento { get; set; }

        public Producto Producto { get; set; }
        public int ProductoId;

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                LineaCompra p = (LineaCompra)obj;
                return (Producto.Nombre== p.Producto.Nombre);
            }
        }
    }
}