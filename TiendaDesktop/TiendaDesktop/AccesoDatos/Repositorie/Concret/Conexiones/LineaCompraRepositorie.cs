using ApiTienda.Models.Request.Concret;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaApp.Src.CategorieDirectory.Services;
using TiendaDesktop.AccesoDatos.Abstracts.Conexiones;
using TiendaDesktop.Services.Concret;

namespace TiendaDesktop.AccesoDatos.Concret.Conexiones
{
    class LineaCompraRepositorie : Repositorie<LineaCompra>, ILineaCompraRep
    {
        private static string LINEACOMPRABYCOMPRAID = "LineCompraByCompraId/{0}";
        public LineaCompraRepositorie () : base 
            (
            name : "LineaCompra"
            )
        { }

        public async Task<List<LineaCompra>> GetByIdCompra(int id)
        {
            var uri = string.Format(LINEACOMPRABYCOMPRAID, id);
            string respuesta = await RestGet.GetHttp(uri);
            List<LineaCompra> list = JsonConvert.DeserializeObject<List<LineaCompra>> (respuesta);
            return list;
        }
    }
}
