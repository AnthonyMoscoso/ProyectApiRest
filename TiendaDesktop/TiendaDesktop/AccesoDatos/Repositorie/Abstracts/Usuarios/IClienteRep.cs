using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDesktop.Core.Repositories;

namespace TiendaDesktop.AccesoDatos.Abstracts.Usuarios
{
    interface IClienteRep : IRepositorie<Cliente>
    {
        Task<List<Cliente>> SearchByDireccion(string filter);

        Task<List<Cliente>> SearchByDireccion(string filter, int page, int elements);
    }
}
