using ApiTienda.Models.Request.Concret;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTienda.Repositories.Abstracts
{
    interface IReservaRepositorie : IRepositorie<ReservaRequest>
    {
        List<ReservaRequest> GetByIdClient(int id);
        List<ReservaRequest> GetByIdClient(int id,int skip,int take);
    }
}
