using ApiTienda.Controllers.Abstracts;
using ApiTienda.Models.Request.Abstract;
using ApiTienda.Repositories.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiTienda.Controllers.Concret
{
    public class ProductoController : ApiController, IProductoController
    {

        ProductoRepositorie _repositorie;
        public ProductoController()
        {
            _repositorie = new ProductoRepositorie();
        }
        [HttpGet]
        [Route("api/ProductoCount")]
        public IHttpActionResult Count()
        {
            return Ok(_repositorie.Count());
        }
        [HttpGet]
        [Route("api/ProductoCount")]
        public IHttpActionResult Count(string filter)
        {
            return Ok(_repositorie.Count(filter));
        }
        [HttpGet]
        [Route("api/GetProductoWhere")]
        public IHttpActionResult GetWhere(string filter)
        {
            return Ok(_repositorie.GetWhere(filter));
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
        [Route("api/ProductoPaginate/{page},{elements}")]
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
        public IHttpActionResult Post(ProductoRequest Entity)
        {
            return Ok(_repositorie.Post(Entity));
        }

        [HttpGet]
        [Route("api/ProductoSearch/")]
        public IHttpActionResult Get(string var)
        {
            return Ok(_repositorie.Get(var));
        }


        [HttpGet]
        [Route("api/ProductoSearch/")]
        public IHttpActionResult Get(string var, int pag, int elements)
        {
            return Ok(_repositorie.Get(var,pag,elements));
        }

        [HttpPut]
        public IHttpActionResult Update(ProductoRequest Entity)
        {
            return Ok(_repositorie.Update(Entity));
        }
        [HttpGet]
        [Route("api/Producto/Cantidad/{id}")]
        public IHttpActionResult CantidadEnInventario(int id)
        {
            return Ok(_repositorie.CantidadEnInventario(id));
        }
    }
}
