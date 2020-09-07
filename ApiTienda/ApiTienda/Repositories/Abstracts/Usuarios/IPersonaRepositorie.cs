using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTienda.Repositories.Abstracts
{
    interface IPersonaRepositorie :IRepositorie<PersonaRequest>
    {
        PersonaRequest Login(string Username, string PassWord);
        bool ExistUsername(string name);
        bool ExistUsername(int id, string name);
        bool ExistEmail(string email);
        bool ExistEmail(int id, string email);
        bool ExistPhone(string number);
        bool ExistPhone(int id,string number);
    }
}
