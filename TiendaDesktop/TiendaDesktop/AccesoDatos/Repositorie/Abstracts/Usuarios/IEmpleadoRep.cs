using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDesktop.Core.Repositories;

namespace TiendaDesktop.AccesoDatos.Abstracts.Usuarios
{
    interface IEmpleadoRep : IRepositorie<Empleado>
    {
        Task<Empleado> GetByDni(string dni);
        Task<bool> ExistDni(string dni);
        Task<bool> ExistDni(int id, string dni);
    }
}
