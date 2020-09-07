using ApiTienda.Controllers.Abstracts;
using ApiTienda.Models.Request.Abstract;
using ApiTienda.Repositories.Concrets.Simples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiTienda.Controllers.Concret
{
    public class PermisoController : ApiController, IPermisoController
    {

        PermisoRepositorie _repositorie;

        public PermisoController()
        {
            _repositorie = new PermisoRepositorie();
        }

        [HttpGet]
        [Route("api/GetPermisoWhere")]
        public IHttpActionResult GetWhere(string filter)
        {
            return Ok(_repositorie.GetWhere(filter));
        }

        [HttpGet]
        [Route("api/PermisoCount")]
        public IHttpActionResult Count()
        {
            return Ok(_repositorie.Count());
        }
        [HttpGet]
        [Route("api/PermisoCount")]
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
        [Route("api/PermisoPaginate/{page},{elements}")]
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
        [Route("api/PermisoSearch")]
        public IHttpActionResult Get(string var)
        {
            return Ok(_repositorie.Get(var));
        }
        [HttpGet]
        [Route("api/PermisoSearch")]
        public IHttpActionResult Get(string var, int pag, int elements)
        {
            return Ok(_repositorie.Get(var,pag,elements));
        }

        [HttpGet]
        [Route("api/PermisosByRol/")]
        public IHttpActionResult GetByRol(int id)
        {
            return Ok(_repositorie.GetByRol(id));
        }

        [HttpPost]
        public IHttpActionResult Post(PermisoRequest Entity)
        {
            return Ok(_repositorie.Post(Entity));
        }

        [HttpPut]
        public IHttpActionResult Update(PermisoRequest Entity)
        {
            return Ok(_repositorie.Update(Entity));
        }
    }
}
