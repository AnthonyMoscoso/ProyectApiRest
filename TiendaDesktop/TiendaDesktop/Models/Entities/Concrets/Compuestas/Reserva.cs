using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaDesktop.Models;
using TiendaDesktop.Models.Abstractas;

namespace ApiTienda.Models.Request.Concret
{
    public class Reserva : IEntidad
    {
        public int Id { get; set; }

        public Producto Producto { get; set; }
        public int Id_Producto
        {
            get
            {
                return Producto != null ? Producto.Id : IdProducto;
            }
            set
            {
                IdProducto = value;
            }
        }
        public Persona Persona { get;set;}
        public int Id_Persona
        {
            get
            {
                return Persona != null ? Persona.Id : IdPersona;
            }
            set
            {
                IdPersona = value;
            }
        }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int Estado { get; set; }


        private int IdProducto;
        private int IdPersona;
    }
}