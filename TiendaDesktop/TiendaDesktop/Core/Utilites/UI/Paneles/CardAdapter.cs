using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDesktop.Models.Abstractas;

namespace TiendaDesktop.Core.Utilites.UI.Paneles
{
    public abstract partial class CardAdapter : UserControl
    {
        public delegate void SendItem(object item) ;
        public SendItem _selectItem;
        private object _select;
        public CardAdapter()
        { 
            InitializeComponent();
        }

        public CardAdapter(object o)
        {
            InitializeComponent();
            _select = o;
            MouseClick += CardAdapter_MouseClick;
        }

        private void CardAdapter_MouseClick(object sender, MouseEventArgs e)
        {
            _selectItem?.Invoke(_select);
        }
    }
}
