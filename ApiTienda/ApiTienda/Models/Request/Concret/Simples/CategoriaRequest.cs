using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTienda.Models.Request.Abstract
{
    public class CategoriaRequest : IEntity
    {
        public int? Id_Categoria_Padre { get; set; }
        public string Nombre { get; set; }
        public int Id { get ; set ; }

    }
}