using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDesktop.Core.Repositories;

namespace TiendaDesktop.AccesoDatos.Abstracts.Compuestas
{
    interface IDevolucionRep : IRepositorie<Devolucion>
    {
        Task<List<Devolucion>> GetByDate(string date);
        Task<List<Devolucion>> GetByDate(string date, int skip, int elements);
    }
}
