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

namespace TiendaDesktop.AccesoDatos.Concret
{
    public class ClienteRepositorie : Repositorie<Cliente>, IClienteRep
    {
        private static string SEARCH_BY_DIRECCION= "SearchByDireccion?filter={0}";
        private static string SEARCH_BY_DIRECCION_Paginate = "SearchByDireccion?filter={0}&page={1}&elements={2}";
        public ClienteRepositorie() : base(
            name: "Cliente"
            )
        {

        }

        public async Task<List<Cliente>> SearchByDireccion(string filter)
        {
            var uri = string.Format(SEARCH_BY_DIRECCION, filter);
            string respuesta = await RestGet.GetHttp(uri);
            List<Cliente> list = JsonConvert.DeserializeObject<List<Cliente>>(respuesta);
            return list;
        }

        public async Task<List<Cliente>> SearchByDireccion(string filter, int page, int elements)
        {
            int skip = (page - 1) * elements;
            var uri = string.Format(SEARCH_BY_DIRECCION_Paginate, filter,skip,elements);
            string respuesta = await RestGet.GetHttp(uri);
            List<Cliente> list = JsonConvert.DeserializeObject<List<Cliente>>(respuesta);
            return list;
        }
    }
}
