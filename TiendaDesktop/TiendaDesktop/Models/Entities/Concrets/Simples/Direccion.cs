using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaDesktop.Models;
using TiendaDesktop.Models.Abstractas;

namespace ApiTienda.Models.Request.Concret
{
    public class Direccion : IEntidad
    {
        public int Id { get; set; }
   
       
        public string CodigoPostal { get; set; }
        public string Ciudad { get; set; }
      
        public string Pais { get; set; }
        public string Calle { get; set; }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}",Pais,Ciudad,CodigoPostal,Calle);
        }


    }
}