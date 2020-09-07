using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDesktop.AccesoDatos.Abstracts.Conexiones;
using TiendaDesktop.Services.Concret;

namespace TiendaDesktop.AccesoDatos.Concret.Conexiones
{
    class PermisosRolRepositorie : Repositorie<PermisosRol>, IPermisosRolRep
    {
        public PermisosRolRepositorie() : base 
            (
            name :"PermisosRol"
            )
        { }
    }
}
