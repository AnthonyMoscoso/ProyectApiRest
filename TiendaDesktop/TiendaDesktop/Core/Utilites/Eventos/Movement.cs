using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI.Eventos
{
    class Movement
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public static void Pn_MouseDown(object sender, MouseEventArgs e)
        {
            Panel f = sender as Panel;
            ReleaseCapture();
            SendMessage(f.Parent.Handle, 0x112, 0xf012, 0);
        }
    }
}
