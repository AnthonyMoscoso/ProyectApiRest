using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTienda.Repositories.Abstracts
{
    interface IClienteRepositorie : IRepositorie<ClienteRequest> 
    {
        List<ClienteRequest> SearchByDireccion(string filter);

        List<ClienteRequest> SearchByDireccion(string filter, int page, int elements) ;

   
    }
}
