using ApiTienda.Controllers.Abstracts.Usuarios;
using ApiTienda.Models.Request.Abstract;
using ApiTienda.Repositories.Concrets.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiTienda.Controllers.Concret.Usuarios
{
    public class EmpleadoController : ApiController, IEmpleadoController
    {
        EmpleadoRepositorie _repositorie;

        public EmpleadoController()
        {
            _repositorie = new EmpleadoRepositorie();
        }
        [HttpGet]
        [Route("api/EmpleadoCount")]
        public IHttpActionResult Count()
        {
            return Ok(_repositorie.Count());
        }
        [HttpGet]
        [Route("api/EmpleadoCount")]
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
        [Route("api/ExistDni/")]
        public IHttpActionResult ExistDni(string dni)
        {
            return Ok(_repositorie.ExistDni(dni));
        }
        [HttpGet]
        [Route("api/ExistDni/")]
        public IHttpActionResult ExistDni(int id, string dni)
        {
            return Ok(_repositorie.ExistDni(id,dni));
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_repositorie.Get());
        }
        [HttpGet]
        [Route("api/EmpleadoPaginate/{page},{elements}")]
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
        [Route("api/EmpleadoByDni/{dni}")]
        public IHttpActionResult GetByDni(string dni)
        {
            return Ok(_repositorie.GetByDni(dni));
        }

        [HttpPost]
        public IHttpActionResult Post(EmpleadoRequest Entity)
        {
            return Ok(_repositorie.Post(Entity));
        }

        [HttpGet]
        [Route("api/EmpleadoSearch/")]
        public IHttpActionResult Get(string var)
        {
            return Ok(_repositorie.Get(var));
        }
        [HttpGet]
        [Route("api/EmpleadoSearch/")]
        public IHttpActionResult Get(string var, int pag, int elements)
        {
            return Ok(_repositorie.Get(var,pag,elements));
        }
        [HttpPut]
        public IHttpActionResult Update(EmpleadoRequest Entity)
        {
            return Ok(_repositorie.Update(Entity));
        }

        [HttpGet]
        [Route("api/GetEmpleadoWhere")]
        public IHttpActionResult GetWhere(string filter)
        {
            return Ok(_repositorie.GetWhere(filter));
        }
    }
}
