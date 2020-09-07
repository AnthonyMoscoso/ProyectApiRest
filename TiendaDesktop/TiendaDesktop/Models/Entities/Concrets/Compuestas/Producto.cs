using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaDesktop.Core.Utilites.Enums;
using TiendaDesktop.Models.Abstractas;

namespace ApiTienda.Models.Request.Abstract
{
#pragma warning disable CS0659 // El tipo reemplaza a Object.Equals(object o), pero no reemplaza a Object.GetHashCode()
    public class Producto : IEntidad
#pragma warning restore CS0659 // El tipo reemplaza a Object.Equals(object o), pero no reemplaza a Object.GetHashCode()
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public int Id_Categoria
        {
            get
            {
                return Categoria != null ? Categoria.Id : Categorie_id;
            }
            set { Categorie_id = value; }
        }

        private int Categorie_id;
      
        public Categoria Categoria { get; set; }

        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Descuento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public EstadosProducto Estado { get; set; }
        public int CantidanInventario { get; set; }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Producto p = (Producto)obj;
                return (Nombre == p.Nombre);
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}