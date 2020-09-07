using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using ApiTienda.Models.Request.Abstract;
using TiendaDesktop.AccesoDatos.Concret.Simples;
using TiendaDesktop.UI.UserControls;
using TiendaDesktop.Core.Utilites.UI.Paneles;

namespace TiendaDesktop.UI.Paneles
{
    public partial class RvCategorias : ReciclerView
    {
        private CategoriaRepositorie _categoriaRepositorie= new CategoriaRepositorie();
        public delegate void SendCategoria(Categoria categoria);
        public SendCategoria _SendCategoria;
        public SendCategoria _SendToEditCategoria;
        private readonly List<CategoriaControl> listControls = new List<CategoriaControl>();
        public RvCategorias()
        {
            InitializeComponent();
            
        }

        public async  void LoadCategoriasWithMenu()
        {
            List<Categoria> list = await _categoriaRepositorie.Get();
            if (pnContainer.Controls.Count > 0)
            {
                pnContainer.Controls.Clear();
            }
            foreach (Categoria item in list)
            {
                if (item.Id_Categoria_Padre is int valueOfa )
                {
                    item.Categoria_Padre = await _categoriaRepositorie.Get((int)item.Id_Categoria_Padre);
                }
             
                CategoriaControl control = new CategoriaControl(item);
                pnContainer.Controls.Add(control);
                control.ActivarMenu();
                control._SendToDelete += Delete_Categoria;
                
            }
        }
   
        private void Delete_Categoria(Categoria categoria)
        {
            _categoriaRepositorie.Delete(categoria);
        }
        public async void LoadCategorias()
        {
            List<Categoria> list = await _categoriaRepositorie.Get();
            if (pnContainer.Controls.Count > 0)
            {
                pnContainer.Controls.Clear();
            }
            foreach (Categoria item in list)
            {
                if(item.Id_Categoria_Padre is int value)
                {
                    item.Categoria_Padre = await _categoriaRepositorie.Get((int)item.Id_Categoria_Padre);
                }
              
                CategoriaControl control = new CategoriaControl(item);
                pnContainer.Controls.Add(control);
                control.Name = item.Nombre;
                listControls.Add(control);
                control._SendCategoria += Send_Categoria;
            }
        }

        public async void LoadCategorias(string filter)
        {
            List<Categoria> list = await _categoriaRepositorie.Get(filter);
            if (pnContainer.Controls.Count > 0)
            {
                pnContainer.Controls.Clear();
            }
            foreach (Categoria item in list)
            {
                if (item.Id_Categoria_Padre is int value)
                {
                    item.Categoria_Padre = await _categoriaRepositorie.Get((int)item.Id_Categoria_Padre);
                }
              
                CategoriaControl control = new CategoriaControl(item);
                pnContainer.Controls.Add(control);
                control.Name = item.Nombre;
                listControls.Add(control);
                control._SendCategoria += Send_Categoria;
            }
        }


        public void Send_Categoria(Categoria categoria)
        {
            _SendCategoria?.Invoke(categoria);
        }

        public void EditCategoria(Categoria categoria)
        {   
            foreach (CategoriaControl control in listControls )
            {
                if (control.Name == categoria.Nombre)
                {
                    control.LoadDatas(categoria);
                }
            }
        }
        public void AddCategoria(Categoria categoria)
        {
            CategoriaControl control = new CategoriaControl(categoria);
            pnContainer.Controls.Add(control);
        }
    }
}
