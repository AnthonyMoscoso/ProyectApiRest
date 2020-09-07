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
    public class ReservaController : ApiController, IReservaController
    {
        ReservaRepositorie _repositorie;

        public ReservaController()
        {
            _repositorie = new ReservaRepositorie();
        }

        [HttpGet]
        [Route("api/ReservaCount")]
        public IHttpActionResult Count()
        {
            return Ok(_repositorie.Count());
        }
        [HttpGet]
        [Route("api/GetReservaWhere")]
        public IHttpActionResult GetWhere(string filter)
        {
            return Ok(_repositorie.GetWhere(filter));
        }
        [HttpGet]
        [Route("api/ReservaCount")]
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
        [Route("api/ReservaPaginate/{page},{elements}")]
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
        [Route("api/ReservaByCliente")]
        public IHttpActionResult GetByIdClient(int id)
        {
            return Ok(_repositorie.GetByIdClient(id));
        }

        [HttpGet]
        [Route("api/ReservaByCliente")]
        public IHttpActionResult GetByIdClient(int id, int page, int elements)
        {
            return Ok(_repositorie.GetByIdClient(id,page, elements));
        }

        [HttpPost]
        public IHttpActionResult Post(ReservaRequest Entity)
        {
            return Ok(_repositorie.Post(Entity));
        }

        [HttpGet]
        [Route("api/ReservaSearch")]
        public IHttpActionResult Get(string var)
        {
            return Ok(_repositorie.Get(var));
        }

        [HttpGet]
        [Route("api/ReservaSearch")]
        public IHttpActionResult Get(string var, int pag, int elements)
        {
            return Ok(_repositorie.Get(var, pag, elements));
        }

        [HttpPut]
        public IHttpActionResult Update(ReservaRequest Entity)
        {
            return Ok(_repositorie.Update(Entity));
        }
    }
}
