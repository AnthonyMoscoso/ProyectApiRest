using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiTienda.Models.Request.Concret;
using TiendaDesktop.Infrastructure.Repositorie.Concret.Simples;
using TiendaDesktop.AccesoDatos.Concret.Compuestas;

namespace TiendaDesktop.UI.UserControls.Adapter
{
    public partial class AdapterLineaCompra : UserControl
    {
        ImageRepositorie _ImageRepositorie = new ImageRepositorie();
        ProductoRepositorie _ProductoRepositorie = new ProductoRepositorie();

        public delegate void Send(LineaCompra linea);
 
        public Send _More;
        public Send _Less;
        public Send _Remove;

        private LineaCompra _linea;
        private int cantidad;
        private int Id;
        public AdapterLineaCompra(LineaCompra linea)
        {
            InitializeComponent();
            _linea = linea;
            cantidad = 1;
            Id = linea.Producto.Id;
            lbName.Text = linea.Producto.Nombre;
            lbPrice.Text = linea.Producto.PrecioCompra+"€";
            lbCantidad.Text = "" + cantidad;
            imgBox.Image = _ImageRepositorie.DownloadImage(linea.Producto.Imagen);
            btnLess.MouseClick += BtnLess_MouseClick;
            btnMore.MouseClick += BtnMore_MouseClick;
            btnRemove.MouseClick += BtnRemove_MouseClick;
        }

        private void BtnRemove_MouseClick(object sender, MouseEventArgs e)
        {
            _Remove?.Invoke(_linea);
            this.Dispose();
        }

        private void BtnMore_MouseClick(object sender, MouseEventArgs e)
        {
            int CantidadInventario = _ProductoRepositorie.GetCantidad(Id).Result;
            _linea.Producto.CantidanInventario = CantidadInventario;
            if (cantidad<CantidadInventario)
            {
                cantidad++;
                _linea.Cantidad++;
                _More?.Invoke(_linea);
                btnLess.Enabled = true;
                btnLess.Visible = true;
                lbCantidad.Text = cantidad.ToString();
            }
            if (cantidad == CantidadInventario)
            {
                btnMore.Enabled = false;
                btnMore.Visible = false;
            }
           
            
        }

        private void BtnLess_MouseClick(object sender, MouseEventArgs e)
        {
            if (cantidad>1)
            {
                cantidad--;
                _linea.Cantidad--;
                lbCantidad.Text = cantidad.ToString();
                _Less?.Invoke(_linea);
            }
            if (cantidad==1)
            {
                btnLess.Enabled = false;
                btnLess.Visible = false;
            }
            
        }
    }
}
