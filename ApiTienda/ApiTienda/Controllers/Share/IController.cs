using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace ApiTienda.Controllers.Abstracts
{
    interface IController<T>
    {
        IHttpActionResult Post(T Entity);
        IHttpActionResult Delete(int id);
        IHttpActionResult Update(T Entity);
        IHttpActionResult  Get();
        IHttpActionResult Get(int page, int elements);
        IHttpActionResult Get(int id);
        IHttpActionResult Count();
        IHttpActionResult Count(string filter);
        IHttpActionResult Get(string var);
        IHttpActionResult Get(string var, int pag, int elements);
        IHttpActionResult GetWhere(string filter);
    }
}
