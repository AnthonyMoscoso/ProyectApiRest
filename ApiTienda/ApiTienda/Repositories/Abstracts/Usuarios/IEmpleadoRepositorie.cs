using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTienda.Repositories.Abstracts
{
    interface IEmpleadoRepositorie : IRepositorie<EmpleadoRequest> 
    {
        EmpleadoRequest GetByDni( string dni);
        bool ExistDni(string dni);
        bool ExistDni(int id, string dni);
    }
}
