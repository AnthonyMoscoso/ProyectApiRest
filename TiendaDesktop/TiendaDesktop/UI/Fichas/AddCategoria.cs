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
using TiendaDesktop.AccesoDatos.Concret.Simples;
using TiendaDesktop.Core.Utilites;
using TiendaDesktop.UI.Forms_Desing;

namespace TiendaDesktop.UI.Fichas
{
    public partial class AddCategoria : Ficha_Categoria
    {
        private Categoria _categoriaSeleccionada;
        private CategoriaRepositorie _categoriaRepositorie;
        private Categoria _categoria= new Categoria();
        public delegate void SendCategoria(Categoria categoria);
        public SendCategoria _CategoriaEdit;
        public SendCategoria _AddCategoria;
        private Categoria nula;
        public AddCategoria()
        {
            InitializeComponent();
            btnAccion.Text = "Añadir";
            btnAccion.MouseClick += BtnAccion_MouseClick;
            _categoriaRepositorie = new CategoriaRepositorie();
           
        }
        private void BtnAccion_MouseClick(object sender, MouseEventArgs e)
        {
            _categoriaSeleccionada = cbxCategorias.SelectedItem as Categoria;
            if (!_categoriaSeleccionada.Nombre.Equals("-------"))
            {
                _categoria.Categoria_Padre = _categoriaSeleccionada;
           
            }
          
            if (!pnDataName.IsEntyTxt())
            {
                _categoria.Nombre = pnDataName.Texto;
                int id =_categoriaRepositorie.Post(_categoria);
                if (id != 0)
                {
                    _categoria.Id = id;
                    _AddCategoria?.Invoke(_categoria);
                }
            }
        }

        public async void LoadCategorias()
        {
            List<Categoria> list = await _categoriaRepositorie.Get();
            nula = new Categoria();
            nula.Nombre = "-------";
            list.Insert(0, nula);
            cbxCategorias.DataSource = list;
        }

     
     
    }
}
