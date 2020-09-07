using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiTienda.Controllers.Abstracts.Usuarios
{
    interface IEmpleadoController : IController<EmpleadoRequest>
    {
        IHttpActionResult GetByDni(string dni);
        IHttpActionResult ExistDni(string dni);
        IHttpActionResult ExistDni(int id, string dni);
    }
}
