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
    public class CompraController : ApiController, ICompraController
    {
        CompraRepositorie _repositorie;

        public CompraController()
        {
            _repositorie = new CompraRepositorie();
        }

        [HttpGet]
        [Route("api/CompraCount")]
        public IHttpActionResult Count()
        {
            return Ok(_repositorie.Count());
        }

        [HttpGet]
        [Route("api/CompraCount")]
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
        [Route("api/CompraPaginate/{page},{elements}")]
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
        [Route("api/ComprasByDate")]
        public IHttpActionResult GetByDate(string date)
        {
            return Ok(_repositorie.GetByDate(date));
        }

        [HttpGet]
        [Route("api/ComprasByDate")]
        public IHttpActionResult GetByDate(string date, int skip, int elements)
        {
            return Ok(_repositorie.GetByDate(date,skip,elements));
        }

        [HttpGet]
        [Route("api/ComprasByIdCliente/{id}")]
        public IHttpActionResult GetComprasByIdCliente(int id)
        {
            return Ok(_repositorie.GetComprasByIdCliente(id));
        }


        [HttpGet]
        [Route("api/ComprasByIdCliente/{id},{date}")]
        public IHttpActionResult GetComprasByIdComprador(int id, string date)
        {
            return Ok(_repositorie.GetComprasByIdComprador(id,date));
        }


        [HttpGet]
        [Route("api/ComprasByIdEmpleado/{id}")]
        public IHttpActionResult GetComprasByIdEmpleado(int id)
        {
            return Ok(_repositorie.GetComprasByIdEmpleado(id));
        }

        [HttpPost]
        public IHttpActionResult Post(CompraRequest Entity)
        {
            return Ok(_repositorie.Post(Entity));
        }

        [HttpGet]
        [Route("api/CompraSearch")]
        public IHttpActionResult Get(string var)
        {
            return Ok(_repositorie.Get(var));
        }
        [HttpGet]
        [Route("api/CompraSearch")]
        public IHttpActionResult Get(string var, int pag, int elements)
        {
            return Ok(_repositorie.Get(var,pag,elements));
        }

        [HttpPut]
        public IHttpActionResult Update(CompraRequest Entity)
        {
            return Ok(_repositorie.Update(Entity));
        }

        [HttpGet]
        [Route("api/GetCompraWhere")]
        public IHttpActionResult GetWhere(string filter)
        {
            return Ok(_repositorie.GetWhere(filter));
        }
    }
}
