using ApiTienda.Models.Request.Concret;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TiendaApp.Core.Utilities;
using TiendaApp.Src.CategorieDirectory.Services;
using TiendaDesktop.AccesoDatos.Abstracts.Compuestas;
using TiendaDesktop.Services.Concret;

namespace TiendaDesktop.AccesoDatos.Concret.Compuestas
{
    public class ReservaRepositorie : Repositorie<Reserva> , IReservaRep
    {
        private static string ReservaByCliente = "ReservaByCliente?id={0}";
        private static string ReservaByCliente_Paginate = "ReservaByCliente?id={0}&page={1}&elements={2}";
        public ReservaRepositorie() : base(
            name: "Reserva"
            )
        {
        }

        public async Task<List<Reserva>> GetByIdClient(int id)
        {
            var uri = string.Format(ReservaByCliente, id);
            string respuesta = await RestGet.GetHttp(uri);
            List<Reserva> list = JsonConvert.DeserializeObject<List<Reserva>>(respuesta);
            return list;
        }

        public async Task<List<Reserva>> GetByIdClient(int id, int skip, int take)
        {
            int n = (skip - 1) * take;
            var uri = string.Format(ReservaByCliente_Paginate, id,n,take);
            string respuesta = await RestGet.GetHttp(uri);
            List<Reserva> list = JsonConvert.DeserializeObject<List<Reserva>>(respuesta);
            return list;
        }
    }
}
