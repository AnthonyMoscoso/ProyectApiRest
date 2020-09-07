using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTienda.Models.Request.Concret
{
    public class ReservaRequest : IEntity
    {
        public int Id { get; set; }
        public int Id_Producto { get; set; }
        public int Id_Persona { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int? Estado { get; set; }
    }
}