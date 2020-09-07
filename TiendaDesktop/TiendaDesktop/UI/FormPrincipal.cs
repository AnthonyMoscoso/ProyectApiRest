using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDesktop.Core.Utilidades.Eventos;
using TiendaDesktop.Core.Utilites;
using TiendaDesktop.UI;
using WindowsFormsUI.Eventos;

namespace TiendaDesktop
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            btnClose.MouseClick += WindowsControl.BtnClose_Click;
            btnMin.MouseClick += WindowsControl.BtnMin_Click;
            btnResize.MouseClick += WindowsControl.BtnResize_Click;
            LoadPanel_Login();
            pnTop.MouseDown += Movement.Pn_MouseDown;
            pnTop.BackColor = ListaColores.BACKGROUND2;

        }


        private void LoadPanel_Login()
        {
            FormApp form = new FormApp();
            OpenForm(form);
        }

        private void OpenForm(object formHijo)
        {
            if (pnContainer.Controls.Count > 0)
            {
                pnContainer.Controls[0].Dispose();
                pnContainer.Controls.Clear();

            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            pnContainer.Controls.Add(fh);
            pnContainer.Tag = fh;
            fh.Show();
        }


    }
}
