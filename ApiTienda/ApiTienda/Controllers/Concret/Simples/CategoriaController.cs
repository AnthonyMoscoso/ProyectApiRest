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
    public class CategoriaController : ApiController, ICategoriaController
    {

        CategoriaRepositorie _repositorie;
        public CategoriaController()
        {
            _repositorie = new CategoriaRepositorie();
        }

        [HttpGet]
        [Route("api/CategoriaCount")]
        public IHttpActionResult Count()
        {
            return Ok(_repositorie.Count());
        }

        [HttpGet]
        [Route("api/CategoriaCount/")]
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
        [Route("api/CategoriasPaginate/{page},{elements}")]
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
        [Route("api/CategoriaSearch")]
        public IHttpActionResult Get(string var)
        {
            return Ok(_repositorie.Get(var));
        }
        [HttpGet]
        [Route("api/CategoriaSearch")]
        public IHttpActionResult Get(string var, int pag, int elements)
        {
            return Ok(_repositorie.Get(var,pag,elements));
        }

        [HttpGet]
        [Route("api/SubcategoriasById/{idCategorie}")]
        public IHttpActionResult GetSubcategorias(int idCategorie)
        {
            return Ok(_repositorie.GetSubcategorias(idCategorie));
        }

        [HttpGet]
        [Route("api/GetCategoriaWhere")]
        public IHttpActionResult GetWhere(string filter)
        {
            return Ok(_repositorie.GetWhere(filter));
        }

        [HttpPost]
        public IHttpActionResult Post(CategoriaRequest Entity)
        {
            return Ok(_repositorie.Post(Entity));
        }

        [HttpPut]
        public IHttpActionResult Update(CategoriaRequest Entity)
        {
            return Ok(_repositorie.Update(Entity));
        }
    }
}
