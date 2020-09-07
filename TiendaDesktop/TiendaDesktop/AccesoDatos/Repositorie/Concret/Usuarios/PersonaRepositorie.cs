using ApiTienda.Models.Request.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaApp.Core.Utilities;
using TiendaApp.Src.CategorieDirectory.Services;
using TiendaDesktop.AccesoDatos.Abstracts.Usuarios;
using TiendaDesktop.Services.Concret;

namespace TiendaDesktop.AccesoDatos.Concret.Usuarios
{
    public class PersonaRepositorie : Repositorie<Persona> ,IPersonaRep
    {
        private static string EXIST_EMAIL= "ExistEmail?email={0}";
        private static string EXIST_USER_WITH_EMAIL=  "ExistEmail?id={0}&email={1}";
        private static string EXIST_PHONE= "ExistPhone/{0}";
        private static string EXIST_USER_WITH_PHONE= "ExistPhone/{0},{1}";
        private static string EXIST_USERNAME= "ExistUsername/{0}";
        private static string EXIST_USER_WITH_USERNAME= "ExistUsername/{0},{1}";
        private static string LOGIN = "Login/{0},{1}";

        public PersonaRepositorie () : base 
            (
            name :"Persona"
            )
        { }

        public async Task<bool> ExistEmail(string email)
        {
            var uri = string.Format(EXIST_EMAIL, email);
            string respuesta = await RestGet.GetHttp(uri);
            bool exist = JsonConvert.DeserializeObject<bool>(respuesta);
            return exist;
        }

        public async Task<bool> ExistEmail(int id, string email)
        {
            var uri = string.Format(EXIST_USER_WITH_EMAIL,id, email);
            string respuesta = await RestGet.GetHttp(uri);
            bool exist = JsonConvert.DeserializeObject<bool>(respuesta);
            return exist;
        }

        public async Task<bool> ExistPhone(string number)
        {
            var uri = string.Format(EXIST_PHONE,number);
            string respuesta = await RestGet.GetHttp(uri);
            bool exist = JsonConvert.DeserializeObject<bool>(respuesta);
            return exist;
        }

        public async Task<bool> ExistPhone(int id, string number)
        {
             var uri = string.Format(EXIST_USER_WITH_PHONE,id, number);
            string respuesta = await RestGet.GetHttp(uri);
            bool exist = JsonConvert.DeserializeObject<bool>(respuesta);
            return exist;
        }

        public async Task<bool> ExistUsername(string name)
        {
            var uri = string.Format(EXIST_USERNAME, name);
            string respuesta = await RestGet.GetHttp(uri);
            bool exist = JsonConvert.DeserializeObject<bool>(respuesta);
            return exist;
        }

        public async Task<bool> ExistUsername(int id, string name)
        {
            var uri = string.Format(EXIST_USER_WITH_USERNAME,id, name);
            string respuesta = await RestGet.GetHttp(uri);
            bool exist = JsonConvert.DeserializeObject<bool>(respuesta);
            return exist;
        }

        public async Task<Persona> Login(string Username, string PassWord)
        {
            var uri = string.Format(LOGIN, Username,PassWord);
            string respuesta = await RestGet.GetHttp(uri);
            Persona e = JsonConvert.DeserializeObject<Persona>(respuesta);
            return e;
        }
    }
}
