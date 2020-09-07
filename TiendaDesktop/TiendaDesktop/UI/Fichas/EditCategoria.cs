using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDesktop.UI.Forms_Desing;
using ApiTienda.Models.Request.Abstract;
using TiendaDesktop.AccesoDatos.Concret.Simples;

namespace TiendaDesktop.UI.Fichas
{
    public partial class EditCategoria : Ficha_Categoria
    {
        private Categoria _categoria;
        private Categoria nula;
        private Categoria _categoriaSeleccionada;
        private CategoriaRepositorie _CategoriaRepositorie;

        public delegate void SendCategoria(Categoria categoria);
        public SendCategoria _CategoriaEdit;
        public EditCategoria()
        {
            InitializeComponent();
            _CategoriaRepositorie = new CategoriaRepositorie();
        }

        public void SendCategoriaToEdit(Categoria categoria)
        {
            _categoria = categoria;
            pnDataName.Texto = categoria.Nombre;
            LoadCategorias(categoria);
            if (categoria.Categoria_Padre != null)
            {
                cbxCategorias.SelectedItem = _categoria.Categoria_Padre;

            }
            else
            {
                cbxCategorias.SelectedItem = nula;
            }

            btnAccion.Text = "Editar";
            btnAccion.MouseClick += Edit_Categoria_Click;
        }


        private void Edit_Categoria_Click(object sender, MouseEventArgs e)
        {

            if (!pnDataName.IsEntyTxt() && IsValid())
            {
                _categoriaSeleccionada = cbxCategorias.SelectedItem as Categoria;
                if (!_categoriaSeleccionada.Nombre.Equals("-------"))
                {
                    _categoria.Categoria_Padre = _categoriaSeleccionada;
                }
                else
                {
                    _categoria.Categoria_Padre = null;
                    _categoria.IdPadre = null;
                    _categoria.Id_Categoria_Padre = null;
                }
                int opcion = _CategoriaRepositorie.Put(_categoria);
                if (opcion != 0)
                {
                    _CategoriaEdit?.Invoke(_categoria);
                }
            }


        }

        private bool IsValid()
        {
            int error = 0;
            string name = pnDataName.Texto;
            int id = _categoria.Id;
            if (!name.Equals(_categoria.Nombre))
            {

                if (ExistName(name))
                {
                    error++;
                }
                else
                {
                    _categoria.Nombre = name;
                    _categoria.Id = id;

                }
                if (error > 0)
                {
                    return false;
                }

            }
            return true;
        }
        private bool ExistName(string name)
        {
            var query = string.Format("Nombre='{0}'", name);
            Categoria exits = _CategoriaRepositorie.GetWhere(query).Result;
            if (exits != null)
            {
                pnDataName.SetErrorMessage("Ya existe una categoria con este nombre");
                return true;
            }
            return false;
        }
        public async void LoadCategorias(Categoria categoria)
        {

            var query = string.Format("Nombre !='{0}'", categoria.Nombre);
            List<Categoria> list = await _CategoriaRepositorie.Get(query);
            nula = new Categoria();
            nula.Nombre = "-------";
            list.Insert(0, nula);
            cbxCategorias.DataSource = list;
        }
    }
}
