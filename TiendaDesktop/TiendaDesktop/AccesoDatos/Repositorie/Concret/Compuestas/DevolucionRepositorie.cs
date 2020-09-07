using ApiTienda.Models.Request.Concret;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaApp.Core.Utilities;
using TiendaApp.Src.CategorieDirectory.Services;
using TiendaDesktop.AccesoDatos.Abstracts.Compuestas;
using TiendaDesktop.Services.Concret;

namespace TiendaDesktop.AccesoDatos.Concret.Compuestas
{
    public class DevolucionRepositorie : Repositorie<Devolucion> , IDevolucionRep
    {
        private static string DevolucionDate = "ComprasByDate?date={0}";
        private static string DevolucionDatePaginate ="ComprasByDate?date={0}&skip={1}&elements={2}";
        public DevolucionRepositorie() : base(
           name: "Devolucion"
           )
        {
        }

        public async Task<List<Devolucion>> GetByDate(string date)
        {
            var uri = string.Format(DevolucionDate, date);
            string respuesta = await RestGet.GetHttp(uri);
            List<Devolucion> list = JsonConvert.DeserializeObject<List<Devolucion>>(respuesta);
            return list;
        }

        public async Task<List<Devolucion>> GetByDate(string date, int skip, int elements)
        {
            var uri = string.Format(DevolucionDatePaginate, date,skip,elements);
            string respuesta = await RestGet.GetHttp(uri);
            List<Devolucion> list = JsonConvert.DeserializeObject<List<Devolucion>>(respuesta);
            return list;
        }
    }
}
