using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiTienda.Controllers.Abstracts.Acciones
{
    interface IDevolucionController : IController<DevolucionRequest> 
    {
        IHttpActionResult GetByDate(string date);
        IHttpActionResult GetByDate(string date, int skip, int elements);
    }
}
