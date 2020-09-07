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

namespace TiendaDesktop.UI.UserControls
{
    public partial class ProductoControl : UserControl
    {
        private Producto _producto;
        private ImageRepositorie _ImageRepositorie;
        public ProductoControl(Producto producto)
        {
            InitializeComponent();
            _ImageRepositorie = new ImageRepositorie();
            _producto = producto;
            lbName.Text = _producto.Nombre;
            imgProducto.Image = _ImageRepositorie.DownloadImage(producto.Imagen);
        }
    }
}
