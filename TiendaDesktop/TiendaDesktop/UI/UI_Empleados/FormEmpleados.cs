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

namespace TiendaDesktop.UI
{
    public partial class FormEmpleados : FormContainers
    {
        public delegate void OpenForm(Empleado empleado);
        public OpenForm _openForm;
        public FormEmpleados()
        {
            InitializeComponent();
            rvContainer.LoadEmpleados();
            rvContainer._SendEmpleado += SendEmpleado_ToEdit;
            btnAdd.MouseClick += BtnAdd_MouseClick;
        }

        private void BtnAdd_MouseClick(object sender, MouseEventArgs e)
        {
            _openForm?.Invoke(null);
        }

        private void SendEmpleado_ToEdit(Empleado empleado)
        {
            _openForm?.Invoke(empleado);
        }


      
    }
}
