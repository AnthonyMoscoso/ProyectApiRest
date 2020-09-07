using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiTienda.Controllers.Abstracts.Acciones
{
    interface IReservaController : IController<ReservaRequest>
    {
        IHttpActionResult GetByIdClient(int id);
        IHttpActionResult GetByIdClient(int id, int skip, int take);
    }
}
