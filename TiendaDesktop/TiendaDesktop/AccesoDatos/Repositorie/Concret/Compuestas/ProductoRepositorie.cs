using ApiTienda.Models.Request.Abstract;
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
    class ProductoRepositorie : Repositorie<Producto> ,IProductoRep
    {
        public ProductoRepositorie(): base(
            name : "Producto"
            )
        { }

        public async Task<int> GetCantidad(int id)
        {
            var uri = string.Format("Producto/Cantidad/{0}", id);
            string respuesta = await RestGet.GetHttp(uri);
            int count = JsonConvert.DeserializeObject<int>(respuesta);
            return count;
        }
    }
}
