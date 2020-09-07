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
    public class CompraRepositorie : Repositorie<Compra> , ICompraRep
    {
        private static string CompraByDate = "ComprasByDate?date={0}";
        private static string CompraByDatePaginate = "ComprasByDate?date={0}&skip={1}&elements={2}";
        private static string ComprasByIdCliente = "ComprasByIdCliente/{0}";
        private static string ComprasByIdEmpleado = " ComprasByIdEmpleado/{0}";
        private static string ComprasByIdClienteAndDate = "ComprasByIdCliente/{0},{1}";
        public CompraRepositorie() : base(
            name:"Compra"
            )
        {
        }

        public async Task<List<Compra>> GetByDate(string date)
        {
            var uri = string.Format(CompraByDate, date);
            string respuesta = await RestGet.GetHttp(uri);
            List <Compra> list = JsonConvert.DeserializeObject<List<Compra>>(respuesta);
            return list;
        }

        public async Task<List<Compra>> GetByDate(string date, int skip, int elements)
        {
            int take = (skip - 1) * elements;
            var uri = string.Format(CompraByDatePaginate, date,take,elements);
            string respuesta = await RestGet.GetHttp(uri);
            List<Compra> list = JsonConvert.DeserializeObject<List<Compra>>(respuesta);
            return list;
        }

        public async Task<List<Compra>> GetComprasByIdCliente(int id)
        {
            var uri = string.Format(ComprasByIdCliente, id);
            string respuesta = await RestGet.GetHttp(uri);
            List<Compra> list = JsonConvert.DeserializeObject<List<Compra>>(respuesta);
            return list;
        }

        public async Task<List<Compra>> GetComprasByIdComprador(int id, string date)
        {
            var uri = string.Format(ComprasByIdClienteAndDate, id,date);
            string respuesta = await RestGet.GetHttp(uri);
            List<Compra> list = JsonConvert.DeserializeObject<List<Compra>>(respuesta);
            return list;
        }

        public async Task<List<Compra>> GetComprasByIdEmpleado(int id)
        {
            var uri = string.Format(ComprasByIdEmpleado, id);
            string respuesta = await RestGet.GetHttp(uri);
            List<Compra> list = JsonConvert.DeserializeObject<List<Compra>>(respuesta);
            return list;
        }
    }
}
