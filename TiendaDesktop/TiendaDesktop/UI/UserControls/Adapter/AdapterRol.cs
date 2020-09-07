using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiTienda.Models.Request.Concret;
using ApiTienda.Models.Request.Abstract;

namespace TiendaDesktop.UI.UserControls.Adapter
{
    public partial class AdapterRol : UserControl
    {
        public delegate void Send(Rol rol);
        private Rol _rol;
        public Send _SendToDelete;
        public Send _SendElement;
     
        public AdapterRol(Rol rol)
        {
            InitializeComponent();
            _rol = rol;
            lbName.Text = rol.Nombre;
            string tool = "";
            foreach (Permiso permiso in _rol.Permisos)
            {
                tool += permiso.ToString()+"\n";
            }
           
            toolTip1.SetToolTip(lbName,tool);
            btnDelete.MouseClick += Button1_MouseClick;
            lbName.MouseClick += Label1_MouseClick;
        }

        private void Label1_MouseClick(object sender, MouseEventArgs e)
        {
            _SendElement?.Invoke(_rol);
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            _SendToDelete?.Invoke(_rol);
            Dispose();
        }
    }
}
