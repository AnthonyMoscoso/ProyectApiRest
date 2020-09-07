using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDesktop.UI.Componentes
{
    public partial class Buscador : UserControl
    {
        public delegate void SendBusqueda(string busqueda);
        public SendBusqueda _EnviarTexto;
        public SendBusqueda _DinamicSearch;

        public Buscador()
        {
            InitializeComponent();
            ptbxCancel.Click += PtbxCancel_Click;
            ptbxLupa.Click += PtbxLupa_Click;
            txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        public string GetTexto()
        {
            return txtSearch.Text;
        }



        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string texto = txtSearch.Text.TrimEnd();
            if (IsTextoValid())
            {

                _DinamicSearch?.Invoke(texto);
            }
            if (texto.Length > 0)
            {
                pnCancel.Visible = true;
            }
            else
            {
                pnCancel.Visible = false;
            }
        }

        private void PtbxLupa_Click(object sender, EventArgs e)
        {
            if (IsTextoValid())
            {
                string text = txtSearch.Text.TrimEnd();
                _EnviarTexto?.Invoke(text);
            }

        }

        private bool IsTextoValid()
        {


            if (txtSearch.Text.Trim().Length > 0 && !txtSearch.Text.Equals(txtSearch.Hint))
            {
                return true;
            }
            return false;
        }


        private void PtbxCancel_Click(object sender, EventArgs e)
        {
            txtSearch.Vaciar();
            pnCancel.Visible = false;
            _DinamicSearch?.Invoke("");
        }

    }
}

