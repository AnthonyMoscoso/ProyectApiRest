using ApiTienda.Models.Request.Concret;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaApp.Src.CategorieDirectory.Services;
using TiendaDesktop.AccesoDatos.Abstracts.Compuestas;
using TiendaDesktop.Services.Concret;

namespace TiendaDesktop.AccesoDatos.Concret.Compuestas
{
    public class PedidoRepositorie : Repositorie<Pedido> , IPedidoRep
    {
        private static string PEDIDO_BY_DATE= "PedidoByDate?date={0}";
        private static string PEDIDO_BY_DATE_PAGINATE = "PedidoByDate?date={0}&skip={1}&elements={2}";
        public PedidoRepositorie() : base(
            name: "Pedido"
            )
        {
        }

        public async Task<List<Pedido>> GetByDate(string date)
        {
            var uri = string.Format(PEDIDO_BY_DATE, date);
            string respuesta = await RestGet.GetHttp(uri);
            List<Pedido> list = JsonConvert.DeserializeObject<List< Pedido >> (respuesta);
            return list;
        }

        public async Task<List<Pedido>> GetByDate(string date, int skip, int elements)
        {
            var uri = string.Format(PEDIDO_BY_DATE_PAGINATE, date);
            string respuesta = await RestGet.GetHttp(uri);
            List<Pedido> list = JsonConvert.DeserializeObject<List<Pedido>>(respuesta);
            return list;
        }
    }
}
