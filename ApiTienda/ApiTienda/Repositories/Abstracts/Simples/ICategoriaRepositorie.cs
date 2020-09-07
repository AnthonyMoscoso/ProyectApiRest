using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTienda.Repositories.Abstracts
{
    interface ICategoriaRepositorie : IRepositorie<CategoriaRequest>
    {
        List<CategoriaRequest> GetSubcategorias(int idCategorie);
    }
}
