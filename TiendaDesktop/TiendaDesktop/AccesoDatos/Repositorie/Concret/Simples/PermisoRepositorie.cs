using ApiTienda.Models.Request.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaApp.Src.CategorieDirectory.Services;
using TiendaDesktop.AccesoDatos.Abstracts.Simples;
using TiendaDesktop.Services.Concret;

namespace TiendaDesktop.AccesoDatos.Concret.Simples
{
    public class PermisoRepositorie : Repositorie<Permiso>,IPermisoRep
    {
        private static string GetPermisosByRol = "PermisosByRol?id={0}";
        public PermisoRepositorie() : base 
            ( name :  "Permiso"
            )
        { }

        public async Task<List<Permiso>> GetByRol(int id)
        {
            var uri = string.Format(GetPermisosByRol, id);
            string respuesta = await RestGet.GetHttp(uri);
            List<Permiso> list = JsonConvert.DeserializeObject<List<Permiso>>(respuesta);
            return list;
        }
    }
}
