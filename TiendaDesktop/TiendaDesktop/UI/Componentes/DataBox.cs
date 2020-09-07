using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDesktop.Core.Utilites;

namespace TiendaDesktop.UI.Componentes
{
    public partial class DataBox : UserControl
    {

        public string Titule { get; set; }
        public bool IsPassword { get; set; }

        private bool IsPassVisible = false;
        
        public string Texto { get; set; }

        public DataBox()
        {
            InitializeComponent();
            this.lbTitutle.MouseClick += LabelTitulo_MouseClick;
            this.lbTitutle.MouseEnter += DataBox_MouseEnter;
            this.MouseLeave += DataBox_MouseLeave;
            this.Paint += DataBox_Paint;
            this.ImgPass.MouseClick += ImgPass_MouseClick;
        }

        private void ImgPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsPassVisible)
            {
                ImgPass.Image = ImagenesResources.EYE_BLOCK;

                txtData.PasswordChar = '\0';
                IsPassVisible = true;
            }
            else
            {
                ImgPass.Image = ImagenesResources.EYE;
                IsPassVisible = false;
                txtData.PasswordChar = '*';
            }
        }

        private void DataBox_MouseEnter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtData.Text))
            {
                this.BackColor = ListaColores.GREY;
            }

        }

        private void DataBox_Paint(object sender, PaintEventArgs e)
        {
            if (!string.IsNullOrEmpty(Titule))
            {
                lbTitutle.Text = Titule;
            }
            if (IsPassword)
            {
                ImgPass.Visible = true;

                txtData.PasswordChar = '*';
            }
            if (!string.IsNullOrEmpty(Texto))
            {
                txtData.Text = Texto;
            }
        }



        private void DataBox_MouseLeave(object sender, EventArgs e)
        {
            string word = txtData.Text;
            if (string.IsNullOrEmpty(word))
            {
                pnData.Visible = false;
                lbTitutle.Font = new Font("Sunset Boulevard", (float)15);
                lbTitutle.AutoSize = false;
                pnData.Dock = DockStyle.Bottom;
                lbTitutle.Dock = DockStyle.Fill;
            }
            else
            {
                lbTitutle.AutoSize = true;
                pnData.Dock = DockStyle.Top;
                lbTitutle.Dock = DockStyle.Top;
            }
            this.BackColor = ListaColores.BLACK;

        }
        private void LabelTitulo_MouseClick(object sender, MouseEventArgs e)
        {
            pnData.Visible = true;
            if (IsPassword)
            {

            }
            this.BackColor = Color.FromArgb(255, 255, 255);
            lbTitutle.AutoSize = true;
            lbTitutle.Dock = DockStyle.Top;
            pnData.Dock = DockStyle.Top;
            txtData.Focus();
            lbTitutle.Font = new Font("Sunset Boulevard", (float)10);
        }

    }
}
