
using System.Collections.Generic;
using ApiTienda.Models.Request.Abstract;
using TiendaDesktop.AccesoDatos.Concret.Compuestas;
using TiendaDesktop.UI.UserControls;
using TiendaDesktop.Core.Utilites.UI.Paneles;

namespace TiendaDesktop.UI.Paneles
{
    public partial class RvProducts : ReciclerView
    {
        private List<Producto> list;
        private ProductoRepositorie _ProductoRepositorie;
        public RvProducts()
        {
            InitializeComponent();
            _ProductoRepositorie = new ProductoRepositorie();
        }
        public async void LoadProducts()
        {
            list = await _ProductoRepositorie.Get();
            LoadPanels(list);
        }
        public async void LoadProducts(int pag,int elements)
        {
            list = await _ProductoRepositorie.Get(pag,elements);
            LoadPanels(list);
        }
        public async void LoadProducts(Categoria categoria)
        {
            var query = string.Format("Id_Categoria ={0}",categoria.Id);
            list = await _ProductoRepositorie.Get(query);
            LoadPanels(list);
        }
        public async void LoadProducts(Categoria categoria,int pag,int elements)
        {
            var query = string.Format("Id_Categoria ={0}", categoria.Id);
            list = await _ProductoRepositorie.Get(query,pag,elements);
            LoadPanels(list);
        }
        public async void LoadProducts(string name)
        {
            var query = string.Format("Nombre ={0}", name);
            list = await _ProductoRepositorie.Get(query);
            LoadPanels(list);
        }
        public async void LoadProducts(string name,int pag,int elements)
        {
            var query = string.Format("Nombre ={0}", name);
            list = await _ProductoRepositorie.Get(query,pag,elements);
            LoadPanels(list);
        }
        public async void LoadProducts(Categoria categoria,string name)
        {
            var query = string.Format("Id_Categoria ={0} AND Nombre={1}", categoria.Id,name);
            list = await _ProductoRepositorie.Get(query);
            LoadPanels(list);
        }

        public async void LoadProducts(Categoria categoria, string name,int pag,int elements)
        {
            var query = string.Format("Id_Categoria ={0} AND Nombre={1}", categoria.Id, name);
            list = await _ProductoRepositorie.Get(query,pag,elements);
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
                ProductoControl productoControl = new ProductoControl(producto);
                pnContainer.Controls.Add(productoControl);
            }
        }
    }
}
