using ApiTienda.Controllers.Abstracts;
using ApiTienda.Models.Request.Concret;
using ApiTienda.Repositories.Concrets.Simples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiTienda.Controllers.Concret
{
    public class RolController : ApiController, IRolController
    {
        RolRepositorie _repositorie;
        public RolController()
        {
            _repositorie = new RolRepositorie();
        }
        [HttpGet]
        [Route("api/RolCount")]
        public IHttpActionResult Count()
        {
            return Ok(_repositorie.Count());
        }
        [HttpGet]
        [Route("api/GetRolWhere")]
        public IHttpActionResult GetWhere(string filter)
        {
            return Ok(_repositorie.GetWhere(filter));
        }
        [HttpGet]
        [Route("api/RolCount")]
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
        [Route("api/RolPaginate/{page},{elements}")]
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
        [Route("api/RolSearch")]
        public IHttpActionResult Get(string var)
        {
            return Ok(_repositorie.Get(var));
        }
        [HttpGet]
        [Route("api/RolSearch")]
        public IHttpActionResult Get(string var, int pag, int elements)
        {
            return Ok(_repositorie.Get(var,pag,elements));
        }

        [HttpPost]
        public IHttpActionResult Post(RolRequest Entity)
        {
            return Ok(_repositorie.Post(Entity));
        }

        [HttpPut]
        public IHttpActionResult Update(RolRequest Entity)
        {
            return Ok(_repositorie.Update(Entity));
        }
    }
}
