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
using TiendaDesktop.AccesoDatos.Concret.Simples;
using TiendaDesktop.UI.Paneles;

namespace TiendaDesktop.UI
{
    public partial class FormCategorias : Form
    {
       
        public FormCategorias()
        {
            InitializeComponent();
            pnCategorias1.LoadCategoriasWithMenu();
            categoriaFicha1.LoadCategorias();
            categoriaFicha1._AddCategoria += Add_Categoria;
            
        }
        public void LoadCategoriasWithMenu()
        {
            pnCategorias1.LoadCategoriasWithMenu();
        }
        public void LoadCategorias()
        {
            pnCategorias1.LoadCategorias();
        }
        private void Add_Categoria(Categoria categoria)
        {
            pnCategorias1.AddCategoria(categoria);
        }
    
    }
}
