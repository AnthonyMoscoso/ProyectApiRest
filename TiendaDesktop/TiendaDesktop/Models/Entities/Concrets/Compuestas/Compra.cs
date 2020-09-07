using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaDesktop.Core.Utilites.Enums;
using TiendaDesktop.Models;
using TiendaDesktop.Models.Abstractas;

namespace ApiTienda.Models.Request.Concret
{
    public class Compra : IEntidad
    {
        public int Id { get; set; }
        public int Id_Comprador {
            get
            {
                return Comprador != null ? Comprador.Id : CompradorId;
            }
            set
            {
                CompradorId = value;
            }
            }

        private  int CompradorId;
        private  int VendedorId;
        public Empleado Vendedor { get; set; }

        public Persona Comprador { get; set; }
        public int Id_Vendedor {
            get
            {
                return Vendedor != null ? Vendedor.Id: VendedorId;
            }
            set
            {
                VendedorId = value;
            }
        }
        public DateTime Fecha { get; set; }
        public FormasDePago FormaPago { get; set; }
        public decimal Descuento { get; set; }

        public List<LineaCompra> LineaCompras { get; set; }
        public override string ToString()
        {
            return "Compra";
        }
    }
}