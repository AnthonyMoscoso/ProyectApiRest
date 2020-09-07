using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsUI.Eventos;

namespace TiendaDesktop.UI
{
    public partial class FormEditCategoria : Form
    {
        private Categoria _categoria;
        public FormEditCategoria( Categoria categoria)
        {
            InitializeComponent();
   
            _categoria = categoria;
            editCategoria1._CategoriaEdit += Edit_Categoria;
             editCategoria1.SendCategoriaToEdit(categoria);
            panel1.MouseDown += Movement.Pn_MouseDown;
        }


        private void Edit_Categoria(Categoria categoria)
        {
            _categoria = categoria;
            DialogResult = DialogResult.OK;
        }

        public Categoria GetCategoria()
        {
            return _categoria;
        }
    }
}