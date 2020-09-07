using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDesktop.UI.Forms
{
    public partial class FormBack : Form
    {
        public delegate void SendBack();
        public SendBack _sendBack;
        public FormBack()
        {
            InitializeComponent();
            btnBack.MouseClick += BtnBack_MouseClick;
        }

        private void BtnBack_MouseClick(object sender, MouseEventArgs e)
        {
            _sendBack?.Invoke(); 
        }
    }
}
