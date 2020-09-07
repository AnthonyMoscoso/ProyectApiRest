using ApiTienda.Controllers.Abstracts;
using ApiTienda.Models.Request.Concret;
using ApiTienda.Repositories.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiTienda.Controllers.Concret
{
    public class DireccionController : ApiController, IDireccionController
    {
        DireccionRepositorie _repositorie;

        public DireccionController()
        {
            _repositorie = new DireccionRepositorie();
        }

        [HttpGet]
        [Route("api/DireccionCount")]
        public IHttpActionResult Count()
        {
            return Ok(_repositorie.Count());
        }
        [HttpGet]
        [Route("api/DireccionCount/{filter}")]
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
        [Route("api/DireccionPaginate/{page},{elements}")]
        public IHttpActionResult Get(int page, int elements)
        {
            return Ok(_repositorie.Get(page,elements));
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok(_repositorie.Get(id));
        }

        [HttpPost]
        public IHttpActionResult Post(DireccionRequest Entity)
        {
            return Ok(_repositorie.Post(Entity));
        }

        [HttpGet]
        [Route("api/DireccionSearch/")]
        public IHttpActionResult Get(string var)
        {
            return Ok(_repositorie.Get(var));
        }
        [HttpGet]
        [Route("api/DireccionSearch/")]
        public IHttpActionResult Get(string var, int pag, int elements)
        {
            return Ok(_repositorie.Get(var,pag,elements));
        }

        [HttpPut]
        public IHttpActionResult Update(DireccionRequest Entity)
        {
            return Ok(_repositorie.Update(Entity));
        }

        [HttpGet]
        [Route("api/GetDireccionWhere")]
        public IHttpActionResult GetWhere(string filter)
        {
            return Ok(_repositorie.GetWhere(filter));
        }
    }
}
