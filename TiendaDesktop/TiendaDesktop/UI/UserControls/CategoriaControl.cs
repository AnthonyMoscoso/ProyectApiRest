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
using TiendaDesktop.Core.Utilites;

namespace TiendaDesktop.UI.UserControls
{
    public partial class CategoriaControl : UserControl
    {
        private Categoria _categoria;
        public delegate void SendCategoria(Categoria categoria);
        public SendCategoria _SendCategoria;
        
        public SendCategoria _SendToDelete;

        public CategoriaControl(Categoria categoria)
        {
            InitializeComponent();
            _categoria = categoria;
            LoadDatas(categoria);
            lbName.MouseEnter += LbName_MouseEnter;
            lbName.MouseLeave += LbName_MouseLeave;
            lbName.MouseClick += LbName_MouseClick;
            
        }
        public void LoadDatas(Categoria categoria)
        {
            _categoria = categoria;
            if (categoria.Categoria_Padre != null)
            {
                lbMaster.Text = categoria.Categoria_Padre.Nombre;
                pnCategoriaUp.Visible = true;
            }
            else
            {
                pnCategoriaUp.Visible = false;
            }
            lbName.Text = _categoria.Nombre;
        }
        public void ActivarMenu()
        {
            btnMenu.ContextMenuStrip = contextMenuStrip1;
            pnButton.Visible = true;
            editarToolStripMenuItem.Click += EditarToolStripMenuItem_Click;
            borrasToolStripMenuItem.Click += BorrasToolStripMenuItem_Click;
        }

        private void BorrasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _SendToDelete?.Invoke(_categoria);
            this.Dispose();
        }

        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditCategoria form = new FormEditCategoria(_categoria);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                _categoria = form.GetCategoria();
                LoadDatas(_categoria);
            }
            
            
        }

       

        private void LbName_MouseClick(object sender, MouseEventArgs e)
        {
            _SendCategoria?.Invoke(_categoria);
        }

        private void LbName_MouseLeave(object sender, EventArgs e)
        {
            lbName.ForeColor = ListaColores.BLACK;
        }

        private void LbName_MouseEnter(object sender, EventArgs e)
        {
            lbName.ForeColor = ListaColores.GREY;
        }

        private void ControlCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
