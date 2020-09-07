using ApiTienda.Models.Request.Concret;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTienda.Repositories.Abstracts
{
    interface ICompraRepositorie : IRepositorie<CompraRequest>
    {
        List<CompraRequest> GetComprasByIdCliente(int id);
        List<CompraRequest> GetComprasByIdEmpleado(int id);
        List<CompraRequest> GetComprasByIdComprador(int id, string date);
        List<CompraRequest> GetByDate(string date);
        List<CompraRequest> GetByDate(string date,int skip,int elements);
    }
}
