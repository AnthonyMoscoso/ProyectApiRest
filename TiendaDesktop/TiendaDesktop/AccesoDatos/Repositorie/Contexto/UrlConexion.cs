using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaApp.Core.Utilities
{
    public class UrlConexion
    {
        private static readonly string IP = "localhost:61001";
        public static string Host =string.Format("http://{0}/api/",IP);

    }
}
