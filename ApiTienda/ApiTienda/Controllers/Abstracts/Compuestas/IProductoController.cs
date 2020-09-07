﻿using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiTienda.Controllers.Abstracts
{
    interface IProductoController : IController<ProductoRequest> 
    {
        IHttpActionResult CantidadEnInventario(int id);
    }
}
