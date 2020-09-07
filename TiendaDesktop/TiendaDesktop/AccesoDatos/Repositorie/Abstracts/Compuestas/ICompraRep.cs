using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDesktop.Core.Repositories;

namespace TiendaDesktop.AccesoDatos.Abstracts.Compuestas
{
    interface ICompraRep : IRepositorie<Compra>
    {
        Task<List<Compra>> GetComprasByIdCliente(int id);
        Task<List<Compra>> GetComprasByIdEmpleado(int id);
        Task<List<Compra>> GetComprasByIdComprador(int id, string date);
        Task<List<Compra>> GetByDate(string date);
        Task<List<Compra>> GetByDate(string date, int skip, int elements);
    }
}
