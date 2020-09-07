using System.IO;
using System.Net;
using System.Threading.Tasks;
using TiendaApp.Core.Utilities;

namespace TiendaApp.Src.CategorieDirectory.Services
{
    public class RestGet
    {
        public static async Task<string> GetHttp(string url)
        {
            try
            {
                var uri = UrlConexion.Host + url;
                WebRequest webResquest = WebRequest.Create(uri);
                WebResponse webResponse = webResquest.GetResponse();
                StreamReader reader = new StreamReader(webResponse.GetResponseStream());
                return await reader.ReadToEndAsync();
            }
            catch(WebException) {
                return "No se ha podido conectar con el servicio compruebe que esta conectado";
            }
        }

        public static async Task<string> GetHttp(string url,string Id)
        {
            try
            {
                WebRequest webResquest = WebRequest.Create(url + Id);
                WebResponse webResponse = webResquest.GetResponse();
                StreamReader reader = new StreamReader(webResponse.GetResponseStream());
                return await reader.ReadToEndAsync();
            }
          

              catch (WebException)
            {
                return "No se ha podido conectar con el servicio compruebe que esta conectado";
            }
        }
    }
}
