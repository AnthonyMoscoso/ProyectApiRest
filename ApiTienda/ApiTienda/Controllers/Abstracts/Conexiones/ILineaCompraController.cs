using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiTienda.Controllers.Abstracts.Conexiones
{
    interface ILineaCompraController : IController<LineaCompraRequest>
    {
        IHttpActionResult GetByIdCompra(int id);
    }
}
