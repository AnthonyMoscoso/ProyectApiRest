using ApiTienda.Controllers.Abstracts;
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
    public class ClienteController : ApiController, IClienteController
    {
        ClienteRepositorie _repositorie;
        public ClienteController()
        {
            _repositorie = new ClienteRepositorie();
        }
        [HttpGet]
        [Route("api/ClienteCount")]
        public IHttpActionResult Count()
        {
            return Ok(_repositorie.Get());
        }
        [HttpGet]
        [Route("api/ClienteCount")]
        public IHttpActionResult Count(string filter)
        {
            return Ok(_repositorie.Get());
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            return Ok(_repositorie.Get());
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_repositorie.Get());
        }
        [HttpGet]
        [Route("api/ClientePaginate/{page},{elements}")]
        public IHttpActionResult Get(int page, int elements)
        {
            return Ok(_repositorie.Get());
        }
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok(_repositorie.Get(id));
        }

        [HttpGet]
        [Route("api/ClienteSearch")]
        public IHttpActionResult Get(string var)
        {
            return Ok(_repositorie.Get(var));
        }
        [HttpGet]
        [Route("api/ClienteSearch")]
        public IHttpActionResult Get(string var, int pag, int elements)
        {
            return Ok(_repositorie.Get(var,pag,elements));
        }

        [HttpGet]
        [Route("api/GetClienteWhere")]
        public IHttpActionResult GetWhere(string filter)
        {
            return Ok(_repositorie.GetWhere(filter));
        }

        [HttpPost]
        public IHttpActionResult Post(ClienteRequest Entity)
        {
            return Ok(_repositorie.Post(Entity));
        }
        [HttpGet]
        [Route("api/SearchByDireccion")]
        public IHttpActionResult SearchByDireccion(string filter)
        {
            return Ok(_repositorie.SearchByDireccion(filter));
        }
        [HttpGet]
        [Route("api/SearchByDireccion")]
        public IHttpActionResult SearchByDireccion(string filter, int page, int elements)
        {
            return Ok(_repositorie.SearchByDireccion(filter,page,elements));
        }

        [HttpPut]
        public IHttpActionResult Update(ClienteRequest Entity)
        {
            return Ok(_repositorie.Update(Entity));
        }
    }
}
