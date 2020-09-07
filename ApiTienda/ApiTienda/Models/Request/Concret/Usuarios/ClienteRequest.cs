using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTienda.Models.Request.Abstract
{
    public class ClienteRequest : PersonaRequest
    {
        public int Id_Persona { get; set; }
        public decimal Descuento { get; set; }

        public DateTime Fecha_Alta { get; set; }
        public DateTime  Fecha_Baja { get; set; }
      
    }
}