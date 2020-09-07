using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDesktop.Core.Utilidades.Eventos
{
    class WindowsControl
    {
        public static void BtnClose_Click(object sender, EventArgs e)
        {
            PictureBox x = sender as PictureBox;
            Panel b = x.Parent as Panel;
            TableLayoutPanel t = b.Parent as TableLayoutPanel;
            Panel p = t.Parent as Panel;
            Form f = p.Parent as Form;
            f.Dispose();
     
        }

        public static void BtnMin_Click(object sender, EventArgs e)
        {

            PictureBox x = sender as PictureBox;
            Panel b = x.Parent as Panel;
            TableLayoutPanel t = b.Parent as TableLayoutPanel;
            Panel p = t.Parent as Panel;
            Form f = p.Parent as Form;
            f.WindowState = FormWindowState.Minimized;
        }

        public static void BtnResize_Click(object sender, EventArgs e)
        {
            PictureBox x = sender as PictureBox;
            Panel b = x.Parent as Panel;
            TableLayoutPanel t = b.Parent as TableLayoutPanel;
            Panel p = t.Parent as Panel;
            Form f = p.Parent as Form;

            if (f.WindowState == FormWindowState.Normal)
            {
               f. WindowState = FormWindowState.Maximized;
            }
            else
            {
               f. WindowState = FormWindowState.Normal;
            }
        }
    }
}
