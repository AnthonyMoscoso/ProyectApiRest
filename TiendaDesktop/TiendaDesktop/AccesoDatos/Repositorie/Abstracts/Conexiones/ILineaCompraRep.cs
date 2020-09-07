using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDesktop.Core.Repositories;

namespace TiendaDesktop.AccesoDatos.Abstracts.Conexiones
{
    interface ILineaCompraRep : IRepositorie<LineaCompra>
    {
        Task<List<LineaCompra>> GetByIdCompra(int id);
    }
}
