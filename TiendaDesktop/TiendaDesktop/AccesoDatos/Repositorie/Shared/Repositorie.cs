using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TiendaApp.Core.Utilities;
using TiendaApp.Src.CategorieDirectory.Services;
using TiendaDesktop.Core.Repositories;
using TiendaDesktop.Models;
using TiendaDesktop.Models.Abstractas;

namespace TiendaDesktop.Services.Concret
{
    public abstract class Repositorie <TEntidad> : IRepositorie<TEntidad>
           where TEntidad: class, IEntidad, new()
    {

        private static string EntityName;

        private static string Url_Entity = "{0}";
        private static string Url_Entity_Count = "{0}Count";
        private static string Url_Entity_CountFilter = "{0}Count?filter={1}";
        private static string Url_Entity_Paginate = "{0}Paginate/{1},{2}";
        private static string Url_Entity_Filter =  "{0}Search?var={1}";
        private static string Url_Entity_Filter_Paginate = "{0}Search?var={1}&pag={2}&elements={elements}";
        private static string Url_Entity_By_Id =  "{0}/{1}";
        private static string Url_Entity_Where = "Get{0}Where?filter={1}";

        public Repositorie(string name)
        {
            EntityName = name;
        }

        public async Task<int> Count()
        {

            var uri = string.Format(Url_Entity_Count,EntityName);
            string respuesta = await RestGet.GetHttp(uri);
            int count = JsonConvert.DeserializeObject<int>(respuesta);
            return count;
        }

        public async Task<int> Count(string filter)
        {
            var url =string.Format(Url_Entity_CountFilter ,EntityName,filter);
            string respuesta = await RestGet.GetHttp(url);
            int count = JsonConvert.DeserializeObject<int>(respuesta);
            return count;
        }

        public string Delete(TEntidad Entity)
        {
            var url = string.Format(Url_Entity_By_Id, EntityName, Entity.Id);
            string message = RestSend.Delete<TEntidad>(url);
            return message;
        }

        public  int Post(TEntidad Entity)
        {
            var url = string.Format(Url_Entity, EntityName, Entity.Id);
            string message = RestSend.Send(url, Entity, SendMetodo.Post.ToString());
            int id = Convert.ToInt32(message);
            return id;
        }

        public  int Put(TEntidad Entity)
        {
            var url = string.Format(Url_Entity, EntityName, Entity.Id);
            string message = RestSend.Send(url, Entity, SendMetodo.PUT.ToString());
            int id = Convert.ToInt32(message);
            return id;
        }

        public async Task<List<TEntidad>> Get()
        {
            var url = string.Format(Url_Entity,EntityName);
            string respuesta = await RestGet.GetHttp(url);
            List<TEntidad> list = JsonConvert.DeserializeObject<List<TEntidad>>(respuesta);
            return list;
        }

        public async Task<List<TEntidad>> Get(int pag, int elements)
        {
            int skip = (pag - 1) * elements;
            var url = string.Format(Url_Entity_Paginate, EntityName,skip,elements);
            string respuesta = await RestGet.GetHttp(url);
            List<TEntidad> list = JsonConvert.DeserializeObject<List<TEntidad>>(respuesta);
            return list;
        }

        public async Task<List<TEntidad>> Get(string filter)
        {
            var url = string.Format(Url_Entity_Filter, EntityName, filter);
            string respuesta = await RestGet.GetHttp(url);
            List<TEntidad> list = JsonConvert.DeserializeObject<List<TEntidad>>(respuesta);
            return list;
        }

        public async Task<List<TEntidad>> Get(string filter, int pag, int elements)
        {
            int skip = (pag - 1) * elements;
            var url = string.Format(Url_Entity_Filter_Paginate, EntityName,filter, skip, elements);
            string respuesta = await RestGet.GetHttp(url);
            List<TEntidad> list = JsonConvert.DeserializeObject<List<TEntidad>>(respuesta);
            return list;
        }

        public async Task<TEntidad> Get(int id)
        {
            var url = string.Format(Url_Entity_By_Id, EntityName,id);
            string respuesta = await RestGet.GetHttp(url);
            TEntidad list = JsonConvert.DeserializeObject<TEntidad>(respuesta);
            return list;
        }

        public async Task<TEntidad> GetWhere(string filter)
        {
            var url = string.Format(Url_Entity_Where, EntityName,filter);
            string respuesta = await RestGet.GetHttp(url);
            TEntidad list = JsonConvert.DeserializeObject<TEntidad>(respuesta);
            return list;
        }
    }
}
