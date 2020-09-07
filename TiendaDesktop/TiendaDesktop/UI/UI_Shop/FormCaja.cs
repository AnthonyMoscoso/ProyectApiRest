using ApiTienda.Models.Request.Abstract;
using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using TiendaDesktop.AccesoDatos.Concret.Simples;
using TiendaDesktop.UI.UserControls.Adapter;

namespace TiendaDesktop.UI
{
    public partial class FormCaja : Form
    {
        CategoriaRepositorie _CategoriaRepositorie;

        public delegate void SendCompra(List<LineaCompra>carrito);
        public SendCompra _send;

        private List<LineaCompra> Carrito = new List<LineaCompra>();
        public FormCaja()
        {
            InitializeComponent();
            _CategoriaRepositorie = new CategoriaRepositorie();
            var query = "Id_Categoria_Padre is null";
            rvCategorias.LoadCategorias(query);
            ReciclerViewProducto.LoadProducts();
            rvCategorias._SendCategoria += Open_Categoria;
            ReciclerViewProducto._send += AddShopList;
            btnClear.MouseClick += BtnClear_MouseClick;
            btnCompra.MouseClick += BtnCompra_MouseClick;
        }

        private void BtnCompra_MouseClick(object sender, MouseEventArgs e)
        {
            if (Carrito.Count>0)
            {
                _send?.Invoke(Carrito);
            }
            else
            {

            }
        }

        private void BtnClear_MouseClick(object sender, MouseEventArgs e)
        {
            Carrito.Clear();
            rvLineaCompra.Clear();
            CalcularTotal();
        }

        private void SetCategoria(Categoria categoria)
        {
            pnSeleccionada.Visible = true;
            btnCancelCategoria.Enabled = true;
            lbCategoriaSeleccionada.Text = categoria.Nombre;
            btnCancelCategoria.MouseClick += BtnCancelCategoria_MouseClick;
        }

        private void BtnCancelCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            pnSeleccionada.Visible = false;
            btnCancelCategoria.Enabled = false;
            var query = "Id_Categoria_Padre is null";
            rvCategorias.LoadCategorias(query);
            ReciclerViewProducto.LoadProducts();
            ReciclerViewProducto._send += AddShopList;
        }
        private void AddShopList(Producto producto)
        {
            LineaCompra linea = new LineaCompra();
            linea.Cantidad = 1;
            linea.Descuento = producto.Descuento;
            linea.Producto = producto;
            linea.Precio = producto.PrecioCompra;

            if (Carrito.Contains(linea))
            {
                MessageBox.Show("Este producto esta ya en el carrito");
            }
            else
            {
                Carrito.Add(linea);
                rvLineaCompra.Add_ELEMENT(linea);
                rvLineaCompra._More += Edit_Cantidad;
                rvLineaCompra._Less += Edit_Cantidad;
                rvLineaCompra._Remove += Get_Remove;
                CalcularTotal();
            }

        }
        private void Get_Remove(LineaCompra linea)
        {
            Carrito.Remove(linea);
            CalcularTotal();

        }
        private void Edit_Cantidad(LineaCompra linea)
        {
            foreach (LineaCompra l in Carrito)
            {
                if (l.Equals(linea))
                {
                    l.Cantidad = linea.Cantidad;
                    CalcularTotal();
                    break;
                }
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (LineaCompra linea in Carrito)
            {
                decimal precio = linea.Precio * linea.Cantidad;
                total += precio;
            }
            lbTotal.Text = string.Format("Total :{0}",total);
        }
        public async void Open_Categoria(Categoria categoria)
        {
            SetCategoria(categoria);
            List<Categoria> subCategorias = await _CategoriaRepositorie.GetSubcategorias(categoria.Id);
            if (subCategorias.Count > 0)
            {
                var query =string.Format( "Id_Categoria_Padre ={0}",categoria.Id);
                rvCategorias.LoadCategorias(query);
            }
            ReciclerViewProducto.LoadProducts(categoria);
        }
    }
}
