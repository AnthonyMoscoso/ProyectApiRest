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
    class CategoriaRepositorie : Repositorie<Categoria>, ICategoriaRep
    {
        private static string GetSubCategorias = "SubcategoriasById/{0}";
        public CategoriaRepositorie () : base 
            (
            name :"Categoria"
            )
        { }

        public async Task<List<Categoria>> GetSubcategorias(int idCategorie)
        {
            var uri = string.Format(GetSubCategorias, idCategorie);
            string respuesta = await RestGet.GetHttp(uri);
            List<Categoria> list = JsonConvert.DeserializeObject<List<Categoria>>(respuesta);
            return list;
        }
    }
}
