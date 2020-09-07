using ApiTienda.Controllers.Abstracts.Conexiones;
using ApiTienda.Models.Request.Concret;
using ApiTienda.Repositories.Concrets.Conexiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiTienda.Controllers.Concret.Conexiones
{
    public class LineaPedidoController : ApiController, ILineaPedidoController
    {
        LineaPedidoRepositorie _repositorie;

        public LineaPedidoController()
        {
            _repositorie = new LineaPedidoRepositorie();
        }

        [HttpGet]
        [Route("api/LineaPedidoCount")]
        public IHttpActionResult Count()
        {
            return Ok(_repositorie.Count());
        }

        [HttpGet]
        [Route("api/LineaPedidoCount")]
        public IHttpActionResult Count(string filter)
        {
            return Ok(_repositorie.Count(filter));
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            return Ok(_repositorie.Delete(id));
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_repositorie.Get());
        }

        [HttpGet]
        [Route("api/LineaPedidoPaginate/{page},{elements}")]
        public IHttpActionResult Get(int page, int elements)
        {
            return Ok(_repositorie.Get(page, elements));
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok(_repositorie.Get(id));
        }

        [HttpPost]
        public IHttpActionResult Post(LineaPedidoRequest Entity)
        {
            return Ok(_repositorie.Post(Entity));
        }

        [HttpGet]
        [Route("api/LineaPedidoSearch/")]
        public IHttpActionResult Get(string var)
        {
            return Ok(_repositorie.Get(var));
        }

        [HttpGet]
        [Route("api/LineaPedidoSearch/")]
        public IHttpActionResult Get(string var, int pag, int elements)
        {
            return Ok(_repositorie.Get(var, pag, elements));
        }

        [HttpPut]
        public IHttpActionResult Update(LineaPedidoRequest Entity)
        {
            return Ok(_repositorie.Update(Entity));
        }

        [HttpGet]
        [Route("api/GetLineaPedidoWhere")]
        public IHttpActionResult GetWhere(string filter)
        {
            return Ok(_repositorie.GetWhere(filter));
        }
    }
}
