using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDesktop.AccesoDatos.Abstracts.Simples;
using TiendaDesktop.Services.Concret;

namespace TiendaDesktop.AccesoDatos.Repositorie.Concret.Simples
{
    class RolRepositorie : Repositorie<Rol>, IRolRep
    {
        public RolRepositorie() : base
         (
         name: "Rol"
         )
        { }
    }
}
