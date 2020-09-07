using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDesktop.Core.Utilidades.Validaciones
{
    class IsElement
    {
        public static bool IsInteger(string numero)
        {
            try
            {
                string n = numero.Replace("\\","n");;
                int.Parse(n);
                return true;
            }
            catch (FormatException )
            {
                return false;
            }
        }
    }
}
