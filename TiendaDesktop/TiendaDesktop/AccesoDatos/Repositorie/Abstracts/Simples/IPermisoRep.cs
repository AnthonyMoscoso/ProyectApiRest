using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDesktop.Core.Repositories;

namespace TiendaDesktop.AccesoDatos.Abstracts.Simples
{
    interface IPermisoRep : IRepositorie<Permiso>
    {
        Task<List<Permiso>> GetByRol(int id);
    }
}
