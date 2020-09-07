using ApiTienda.Controllers.Abstracts.Acciones;
using ApiTienda.Models.Request.Concret;
using ApiTienda.Repositories.Concrets.Acciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiTienda.Controllers.Concret.Acciones
{
    public class PedidoController : ApiController, IPedidoController
    {

        PedidoRepositorie _repositorie;

        public PedidoController()
        {
            _repositorie = new PedidoRepositorie();
        }

        [HttpGet]
        [Route("api/PedidoCount")]
        public IHttpActionResult Count()
        {
            return Ok(_repositorie.Count());
        }

        [HttpGet]
        [Route("api/PedidoCount")]
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
        [Route("api/PedidoPaginate/{page},{elements}")]
        public IHttpActionResult Get(int page, int elements)
        {
            return Ok(_repositorie.Get(page, elements));
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok(_repositorie.Get(id));
        }
        [HttpGet]
        [Route("api/PedidoByDate")]
        public IHttpActionResult GetByDate(string date)
        {
            return Ok(_repositorie.GetByDate(date));
        }
        [HttpGet]
        [Route("api/PedidoByDate")]
        public IHttpActionResult GetByDate(string date, int skip, int elements)
        {
            return Ok(_repositorie.GetByDate(date,skip,elements));
        }
        
        [HttpPost]
        public IHttpActionResult Post(PedidoRequest Entity)
        {
            return Ok(_repositorie.Post(Entity));
        }

        [HttpGet]
        [Route("api/PedidoSearch")]
        public IHttpActionResult Get(string var)
        {
            return Ok(_repositorie.Get(var));
        }

        [HttpGet]
        [Route("api/PedidoSearch")]
        public IHttpActionResult Get(string var, int pag, int elements)
        {
            return Ok(_repositorie.Get(var, pag, elements));
        }

        [HttpPut]
        public IHttpActionResult Update(PedidoRequest Entity)
        {
            return Ok(_repositorie.Update(Entity));
        }

        [HttpGet]
        [Route("api/GetPedidoWhere")]
        public IHttpActionResult GetWhere(string filter)
        {
            return Ok(_repositorie.GetWhere(filter));
        }
    }
}
