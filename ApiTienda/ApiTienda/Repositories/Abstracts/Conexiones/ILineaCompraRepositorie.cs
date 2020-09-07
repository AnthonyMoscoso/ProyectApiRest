using ApiTienda.Controllers.Abstracts;
using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTienda.Repositories.Abstracts
{
    interface ILineaCompraRepositorie : IRepositorie<LineaCompraRequest>
    {
        List<LineaCompraRequest> GetByIdCompra(int id);
    }
}
