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
    public partial class AdapterEmpleado : UserControl
    {
        private Empleado _empleado;
        public delegate void Send(Empleado empleado);
        public Send _SendEmpleado;
        public AdapterEmpleado(Empleado empleado)
        {
            InitializeComponent();
            _empleado = empleado;
            LoadEmpleadoDatos(_empleado);
            btnMore.MouseClick += BtnMore_MouseClick;
           
        }

        private void BtnMore_MouseClick(object sender, MouseEventArgs e)
        {
            _SendEmpleado?.Invoke(_empleado);
        }

        private void LoadEmpleadoDatos(Empleado empleado)
        {
            
            lbName.Text = string.Format("{0} {1}",empleado.Nombre,empleado.Apellido);
            lbEmail.Text = string.Format("Email:{0}",empleado.Email);
 
            lbPhone.Text = string.Format("Telefono:{0}", empleado.Telefono);
            lbRol.Text = string.Format("Rol:{0}", empleado.Rol.Nombre);
     

        }
    }
}
