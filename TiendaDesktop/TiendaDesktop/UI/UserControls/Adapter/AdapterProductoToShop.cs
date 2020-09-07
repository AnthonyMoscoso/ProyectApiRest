using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiTienda.Models.Request.Abstract;
using TiendaDesktop.Infrastructure.Repositorie.Concret.Simples;

namespace TiendaDesktop.UI.UserControls.Adapter
{
    public partial class AdapterProductoToShop : UserControl
    {
        ImageRepositorie _ImageRepositorie;
        public delegate void Send(Producto producto);
        public Send _send;
        private Producto _producto;
        public AdapterProductoToShop(Producto producto)
        {
            InitializeComponent();
            _producto = producto;
            lbName.Text = producto.Nombre;
            _ImageRepositorie = new ImageRepositorie();
           
            ptImg.Image = _ImageRepositorie.DownloadImage(producto.Imagen);
            ptImg.MouseClick += PtImg_MouseClick; 
            lbName.MouseClick += LbName_MouseClick;
        }

        private void LbName_MouseClick(object sender, MouseEventArgs e)
        {
            _send?.Invoke(_producto);
        }

        private void PtImg_MouseClick(object sender, MouseEventArgs e)
        {
            _send?.Invoke(_producto);
        }
    }
}
