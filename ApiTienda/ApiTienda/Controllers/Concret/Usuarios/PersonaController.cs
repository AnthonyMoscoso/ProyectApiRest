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
    public class PersonaController : ApiController, IPersonaController
    {
        PersonaRepositorie _repositorie;
        public PersonaController()
        {
            _repositorie = new PersonaRepositorie();
        }

        [HttpGet]
        [Route("api/PersonaCount")]
        public IHttpActionResult Count()
        {
            return Ok(_repositorie.Count());
        }
        [HttpGet]
        [Route("api/PersonaCount")]
        public IHttpActionResult Count(string filter)
        {
            return Ok(_repositorie.Count(filter));
        }
        [HttpGet]
        [Route("api/GetPersonaWhere")]
        public IHttpActionResult GetWhere(string filter)
        {
            return Ok(_repositorie.GetWhere(filter));
        }
        public IHttpActionResult Delete(int id)
        {
            return Ok(_repositorie.Delete(id));
        }
        [HttpGet]
        [Route("api/ExistEmail")]
        public IHttpActionResult ExistEmail(string email)
        {
            return Ok(_repositorie.ExistEmail(email));
        }
        [HttpGet]
        [Route("api/ExistEmail")]
        public IHttpActionResult ExistEmail(int id, string email)
        {
            return Ok(_repositorie.ExistEmail(id, email));
        }
        [HttpGet]
        [Route("api/ExistPhone/{number}")]
        public IHttpActionResult ExistPhone(string number)
        {
            return Ok(_repositorie.ExistPhone(number));
        }
        [HttpGet]
        [Route("api/ExistPhone/{id},{number}")]
        public IHttpActionResult ExistPhone(int id, string number)
        {
            return Ok(_repositorie.ExistPhone(id, number));
        }
        [HttpGet]
        [Route("api/ExistUsername/{name}")]
        public IHttpActionResult ExistUsername(string name)
        {
            return Ok(_repositorie.ExistUsername(name));
        }
        [HttpGet]
        [Route("api/ExistUsername/{id},{name}")]
        public IHttpActionResult ExistUsername(int id, string name)
        {
            return Ok(_repositorie.ExistUsername(id, name));
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_repositorie.Get());
        }
        [HttpGet]
        [Route("api/PersonaPaginate/{page},{elements}")]
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
        [Route("api/PersonaSearch")]
        public IHttpActionResult Get(string var)
        {
            return Ok(_repositorie.Get(var));
        }
        [HttpGet]
        [Route("api/PersonaSearch")]
        public IHttpActionResult Get(string var, int pag, int elements)
        {
            return Ok(_repositorie.Get(var,pag ,elements));
        }

        [HttpGet]
        [Route("api/Login/{Username},{PassWord}")]
        public IHttpActionResult Login(string Username, string PassWord)
        {
            return Ok(_repositorie.Login(Username, PassWord));
        }
        [HttpPost]
        public IHttpActionResult Post(PersonaRequest Entity)
        {
            return Ok(_repositorie.Post(Entity));
        }
      
        [HttpPut]
        public IHttpActionResult Update(PersonaRequest Entity)
        {
            return Ok(_repositorie.Update(Entity));
        }
    }
}
