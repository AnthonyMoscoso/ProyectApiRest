using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDesktop.Core.Repositories;

namespace TiendaDesktop.AccesoDatos.Abstracts.Usuarios
{
    interface IPersonaRep : IRepositorie<Persona>
    {
        Task<Persona> Login(string Username, string PassWord);
        Task<bool> ExistUsername(string name);
        Task<bool> ExistUsername(int id, string name);
        Task<bool> ExistEmail(string email);
        Task<bool> ExistEmail(int id, string email);
        Task<bool> ExistPhone(string number);
        Task<bool> ExistPhone(int id, string number);
    }
}
