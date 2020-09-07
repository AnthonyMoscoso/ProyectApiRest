using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiTienda.Controllers.Abstracts
{
    interface IClienteController : IController<ClienteRequest>
    {
        IHttpActionResult SearchByDireccion(string filter);

        IHttpActionResult SearchByDireccion(string filter, int page, int elements);

    }
}
