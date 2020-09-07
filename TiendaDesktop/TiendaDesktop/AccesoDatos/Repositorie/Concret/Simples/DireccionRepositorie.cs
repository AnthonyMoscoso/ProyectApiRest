using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDesktop.AccesoDatos.Abstracts;
using TiendaDesktop.Services.Concret;

namespace TiendaDesktop.AccesoDatos.Concret
{
    public class DireccionRepositorie : Repositorie<Direccion> , IDireccionRep
    {
        public DireccionRepositorie() : base(
            name :"Direccion"
            )
        {

        }
    }
}
