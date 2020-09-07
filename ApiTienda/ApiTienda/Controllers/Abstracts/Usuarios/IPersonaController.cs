using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiTienda.Controllers.Abstracts
{
    interface IPersonaController : IController<PersonaRequest>
    {
       
        IHttpActionResult Login(string Username, string PassWord);

        IHttpActionResult ExistUsername(string name);
        IHttpActionResult ExistUsername(int id, string name);

        IHttpActionResult ExistEmail(string email);
        IHttpActionResult ExistEmail(int id, string name);

        IHttpActionResult ExistPhone(string number);
        IHttpActionResult ExistPhone(int id, string number);
    }
}
