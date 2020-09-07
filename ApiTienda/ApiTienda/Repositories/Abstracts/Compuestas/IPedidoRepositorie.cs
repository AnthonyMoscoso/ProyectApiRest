using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTienda.Repositories.Abstracts
{
    interface IPedidoRepositorie : IRepositorie<PedidoRequest>
    {
        List<PedidoRequest> GetByDate(string date);
        List<PedidoRequest> GetByDate(string date, int skip, int elements);
    }
}
