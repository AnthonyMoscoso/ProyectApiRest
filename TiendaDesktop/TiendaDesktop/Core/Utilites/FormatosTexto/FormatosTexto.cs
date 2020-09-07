using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDesktop.Core.Utilites.FormatosTexto
{
    public class FormatosTexto
    {
        public static void Underline(System.Windows.Forms.Label label)
        {
            label.Font = new Font(label.Font, FontStyle.Underline);
           
        }
        public static void StrikeOut(System.Windows.Forms.Label label)
        {
            label.Font = new Font(label.Font, FontStyle.Strikeout);
        }
        public static void Bold(System.Windows.Forms.Label label)
        {
            label.Font = new Font(label.Font, FontStyle.Bold);
        }
        public static void Italic(System.Windows.Forms.Label label)
        {
            label.Font = new Font(label.Font, FontStyle.Italic);
        }
        public static void Normal(System.Windows.Forms.Label label)
        {
            label.Font = new Font(label.Font, FontStyle.Regular);
        }

        public static void CambiarFormato(System.Windows.Forms.Label label,bool bold,bool underline,bool  strike,bool italic)
        {
            if (bold & underline & italic & strike)
            {
                label.Font = new Font(label.Font, FontStyle.Bold | FontStyle.Underline | FontStyle.Strikeout | FontStyle.Italic);
            }
            else if (!bold & !underline & !italic & strike)
            {
                label.Font = new Font(label.Font ,FontStyle.Strikeout) ;
            }
            else if (!bold & !underline & italic & !strike)
            {
                label.Font = new Font(label.Font, FontStyle.Italic);
            }
            else if (!bold & !underline & italic & strike)
            {
                label.Font = new Font(label.Font, FontStyle.Italic | FontStyle.Strikeout);
            }
            else if (!bold & underline &!italic & !strike)
            {
                label.Font = new Font(label.Font, FontStyle.Underline);
            }

            else if (!bold & underline & !italic & strike)
            {
                label.Font = new Font(label.Font, FontStyle.Underline | FontStyle.Strikeout);
            }
            else if (!bold & underline & italic & !strike)
            {
                label.Font = new Font(label.Font, FontStyle.Underline | FontStyle.Italic);
            }
            else if (!bold & underline & italic & strike)
            {
                label.Font = new Font(label.Font, FontStyle.Underline | FontStyle.Italic | FontStyle.Strikeout);
            }
            else if (bold & !underline & !italic & !strike)
            {
                label.Font = new Font(label.Font, FontStyle.Bold);
            }
            else if (bold & !underline & !italic & strike)
            {
                label.Font = new Font(label.Font, FontStyle.Bold | FontStyle.Strikeout);
            }
            else if (bold & !underline & italic & !strike)
            {
                label.Font = new Font(label.Font, FontStyle.Bold | FontStyle.Italic);
            }
            else if (bold & !underline & italic & strike)
            {
                label.Font = new Font(label.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout);
            }
            else if (bold & underline & !italic & !strike)
            {
                label.Font = new Font(label.Font, FontStyle.Bold | FontStyle.Underline);
            }
            else if (bold & underline & !italic & strike)
            {
                label.Font = new Font(label.Font, FontStyle.Bold | FontStyle.Underline | FontStyle.Strikeout);
            }
            else if (bold & underline & italic & !strike)
            {
                label.Font = new Font(label.Font, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
            }
            else
            {
                label.Font = new Font(label.Font, FontStyle.Regular);
            }

        }
    }
}
