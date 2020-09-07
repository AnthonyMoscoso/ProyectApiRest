using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDesktop.Core.Repositories;

namespace TiendaDesktop.AccesoDatos.Abstracts.Compuestas
{
    interface IReservaRep : IRepositorie<Reserva>
    {
        Task<List<Reserva>> GetByIdClient(int id);
        Task<List<Reserva>> GetByIdClient(int id, int skip, int take);
    }
}
