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
using TiendaDesktop.UI.Forms_Desing;

namespace TiendaDesktop.UI.UI_Socios
{
    public partial class FormClientes : FormContainers
    {
        public delegate void OpenForm(Cliente entity);
        public OpenForm _openForm;
        public FormClientes()
        {
            InitializeComponent();
            rvContainer.LoadEntitys();
            rvContainer._SendEntity += SendEntity_ToEdit;
        }

        private void SendEntity_ToEdit(Cliente entity)
        {
            _openForm?.Invoke(entity);
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            _openForm?.Invoke(null);
        }
    }
}