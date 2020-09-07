using ApiTienda.Controllers.Abstracts.Acciones;
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
    public class LineaCompraController : ApiController, ILineaCompraController
    {
        LineaCompraRepositorie _repositorie;

        public LineaCompraController()
        {
            _repositorie = new LineaCompraRepositorie();
        }

        [HttpGet]
        [Route("api/LineaCompraCount")]
        public IHttpActionResult Count()
        {
            return Ok(_repositorie.Count());
        }

        [HttpGet]
        [Route("api/LineaCompraCount")]
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
        [Route("api/LineaCompraPaginate/{page},{elements}")]
        public IHttpActionResult Get(int page, int elements)
        {
            return Ok(_repositorie.Get(page,elements));
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok(_repositorie.Get(id));
        }
        [HttpGet]
        [Route("api/LineaCompraSearch")]
        public IHttpActionResult Get(string var)
        {
            return Ok(_repositorie.Get(var));
        }
        [HttpGet]
        [Route("api/LineaCompraSearch")]
        public IHttpActionResult Get(string var, int pag, int elements)
        {
            return Ok(_repositorie.Get(var,pag,elements));
        }

        [HttpGet]
        [Route("api/LineCompraByCompraId/{id}")]
        public IHttpActionResult GetByIdCompra(int id)
        {
            return Ok(_repositorie.GetByIdCompra(id));
        }

        [HttpPost]
        public IHttpActionResult Post(LineaCompraRequest Entity)
        {
            return Ok(_repositorie.Post(Entity));
        }

        [HttpPut]
        public IHttpActionResult Update(LineaCompraRequest Entity)
        {
            return Ok();
        }

        [HttpGet]
        [Route("api/GetLineaCompraWhere")]
        public IHttpActionResult GetWhere(string filter)
        {
            return Ok(_repositorie.GetWhere(filter));
        }
    }
}
