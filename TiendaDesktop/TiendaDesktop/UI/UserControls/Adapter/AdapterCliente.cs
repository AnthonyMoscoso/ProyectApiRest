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

namespace TiendaDesktop.UI.UserControls.Adapter
{
    public partial class AdapterCliente : UserControl
    {
        private Cliente _entity;
        public delegate void Send(Cliente entity);
        public Send _SendEntity;
        public AdapterCliente(Cliente entity)
        {
            InitializeComponent();
            _entity = entity;
            LoadEmpleadoDatos(_entity);
            btnMore.MouseClick += BtnMore_MouseClick;

        }

        private void BtnMore_MouseClick(object sender, MouseEventArgs e)
        {
            _SendEntity?.Invoke(_entity);
        }

        private void LoadEmpleadoDatos(Cliente entity)
        {
            lbName.Text = string.Format("{0} {1}", entity.Nombre, entity.Apellido);
            lbEmail.Text = string.Format("Email:{0}", entity.Email);
            lbPhone.Text = string.Format("Telefono:{0}", entity.Telefono);



        }
    }
}
