using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaDesktop.Models;
using TiendaDesktop.Models.Abstractas;

namespace ApiTienda.Models.Request.Concret
{
    public class Pedido : IEntidad
    {
        public int Id { get; set; }

        private  int Empleado_Id;
        public Empleado Empleado;

        public int Id_Empleado
        {
            get
            {
                return Empleado != null ? Empleado.Id : Empleado_Id;
            }
            set => Empleado_Id = value;
        }
        public DateTime Fecha { get; set; }
        
        public List<Pedido> Pedidos { get; set; }
    }
}