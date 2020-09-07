using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDesktop.Core.Utilites.UI.Paneles;
using TiendaDesktop.AccesoDatos.Concret.Compuestas;
using ApiTienda.Models.Request.Abstract;
using TiendaDesktop.UI.UserControls.Adapter;

namespace TiendaDesktop.UI.Views
{
    public partial class RvProductToShop : ReciclerView
    {
        ProductoRepositorie _ProductoRepositorie;
        private List<Producto> list;
        public delegate void Send(Producto producto);
        public Send _send;
        public RvProductToShop()
        {
            InitializeComponent();
            _ProductoRepositorie = new ProductoRepositorie();
        }

        public async void LoadProducts()
        {
            list = await _ProductoRepositorie.Get();
            LoadPanels(list);
        }
        public async void LoadProducts(int pag, int elements)
        {
            list = await _ProductoRepositorie.Get(pag, elements);
            LoadPanels(list);
        }
        public async void LoadProducts(Categoria categoria)
        {
            var query = string.Format("Id_Categoria ={0} ;", categoria.Id);
            list = await _ProductoRepositorie.Get(query);
            LoadPanels(list);
        }
        public async void LoadProducts(Categoria categoria, int pag, int elements)
        {
            var query = string.Format("Id_Categoria ={0}", categoria.Id);
            list = await _ProductoRepositorie.Get(query, pag, elements);
            LoadPanels(list);
        }
        public async void LoadProducts(string name)
        {
            var query = string.Format("Nombre ={0}", name);
            list = await _ProductoRepositorie.Get(query);
            LoadPanels(list);
        }
        public async void LoadProducts(string name, int pag, int elements)
        {
            var query = string.Format("Nombre ={0}", name);
            list = await _ProductoRepositorie.Get(query, pag, elements);
            LoadPanels(list);
        }
        public async void LoadProducts(Categoria categoria, string name)
        {
            var query = string.Format("Id_Categoria ={0} AND Nombre={1}", categoria.Id, name);
            list = await _ProductoRepositorie.Get(query);
            LoadPanels(list);
        }

        public async void LoadProducts(Categoria categoria, string name, int pag, int elements)
        {
            var query = string.Format("Id_Categoria ={0} AND Nombre={1}", categoria.Id, name);
            list = await _ProductoRepositorie.Get(query, pag, elements);
            LoadPanels(list);
        }
        private void LoadPanels(List<Producto> list)
        {
            if (pnContainer.Controls.Count > 0)
            {
                pnContainer.Controls.Clear();
            }
            foreach (Producto producto in list)
            {
                AdapterProductoToShop adapter = new AdapterProductoToShop(producto);
                pnContainer.Controls.Add(adapter);
                adapter._send += Send_Producto;
            }
        }

        public void Send_Producto(Producto producto)
        {
            _send?.Invoke(producto);
        }
    }
}
