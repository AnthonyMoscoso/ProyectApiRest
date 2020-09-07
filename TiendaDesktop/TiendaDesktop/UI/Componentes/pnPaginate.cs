using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDesktop.UI.Componentes
{
    public partial class pnPaginate : UserControl
    {
        public delegate void SendMessage();
        public SendMessage _NextPagina;
        public SendMessage _BeforePagina;
        public SendMessage _FirstPagina;
        public SendMessage _LastPagina;
        public int Maxpag { get; set; }

        private int pag;
        public pnPaginate()
        {
            InitializeComponent();
            btnBefore.MouseClick += BtnBefore_MouseClick;
            btnFirst.MouseClick += BtnFirst_MouseClick;
            btnLast.MouseClick += BtnLast_MouseClick;
            btnNext.MouseClick += BtnNext_MouseClick;
            Maxpag = 1;
            this.Paint += PnPaginate_Paint;
            pag = 1;
        }

        private void PnPaginate_Paint(object sender, PaintEventArgs e)
        {
            if (Maxpag != 0)
            {
                lbPag.Text = string.Format("1/{0}", Maxpag);
            }
        }

        private void BtnNext_MouseClick(object sender, MouseEventArgs e)
        {
            if (pag < Maxpag)
            {
                _NextPagina?.Invoke();
                pag ++;
                PainLabel();
            }
        }

        private void BtnLast_MouseClick(object sender, MouseEventArgs e)
        {
            if (pag <Maxpag)
            {
                _LastPagina?.Invoke();
                pag = Maxpag;
                PainLabel();
            }
            
        }

        private void BtnFirst_MouseClick(object sender, MouseEventArgs e)
        {

            if (pag > 1)
            {
                _FirstPagina?.Invoke();
                pag = 1;
                PainLabel();
            }
        }

        private void BtnBefore_MouseClick(object sender, MouseEventArgs e)
        {
            if (pag > 1)
            {
                _BeforePagina?.Invoke();
                pag--;
                PainLabel();

            }
        }

        private void PainLabel()
        {
            lbPag.Text = string.Format("{0}/{1}",pag, Maxpag);
        }

      

    
    }
}
