using ApiTienda.Models.Request.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaApp.Src.CategorieDirectory.Services;
using TiendaDesktop.AccesoDatos.Abstracts.Usuarios;
using TiendaDesktop.Services.Concret;

namespace TiendaDesktop.AccesoDatos.Concret.Usuarios
{
    public class EmpleadoRepositorie : Repositorie<Empleado> , IEmpleadoRep
    {
        private static string EXIST_DNI= "ExistDni?dni={0}";
        private static string EXIST_USER_WITH_DNI= "ExistDni?id={0}&dni={1}";
        private static string EMPLEADO_BY_DNI = "EmpleadoByDni/{0}";
        public EmpleadoRepositorie () : base 
            (
            name : "Empleado"
            )
        { }

        public async Task<bool> ExistDni(string dni)
        {
            var uri = string.Format(EXIST_DNI, dni);
            string respuesta = await RestGet.GetHttp(uri);
            bool exist = JsonConvert.DeserializeObject<bool>(respuesta);
            return exist;
        }

        public async Task<bool> ExistDni(int id, string dni)
        {
            var uri = string.Format(EXIST_USER_WITH_DNI,id, dni);
            string respuesta = await RestGet.GetHttp(uri);
            bool exist = JsonConvert.DeserializeObject<bool>(respuesta);
            return exist;
        }

        public async Task<Empleado> GetByDni(string dni)
        {
            var uri = string.Format(EMPLEADO_BY_DNI, dni);
            string respuesta = await RestGet.GetHttp(uri);
            Empleado e = JsonConvert.DeserializeObject<Empleado>(respuesta);
            return e;
        }
    }
}
