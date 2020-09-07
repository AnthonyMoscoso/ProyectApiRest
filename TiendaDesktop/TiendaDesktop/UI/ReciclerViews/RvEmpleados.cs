using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDesktop.AccesoDatos.Concret.Usuarios;
using ApiTienda.Models.Request.Abstract;
using TiendaDesktop.AccesoDatos.Concret;
using TiendaDesktop.UI.UserControls.Adapter;
using TiendaDesktop.Core.Utilites.UI.Paneles;
using TiendaDesktop.AccesoDatos.Repositorie.Concret.Simples;
using System.Diagnostics.Eventing.Reader;

namespace TiendaDesktop.UI.Paneles
{
    public partial class RvEmpleados : ReciclerView
    { 
        private EmpleadoRepositorie _EmpleadoRepositorie;
        private DireccionRepositorie _DireccionRepositorie;
        private RolRepositorie _rolRepositorie;
        private List<Empleado> list;

        public delegate void Send(Empleado empleado);
        public Send _SendEmpleado;

        public RvEmpleados()
        {
            InitializeComponent();
            _EmpleadoRepositorie = new EmpleadoRepositorie();
            _DireccionRepositorie = new DireccionRepositorie();
            _rolRepositorie = new RolRepositorie();
        }

        public async void LoadEmpleados()
        {
            list = await _EmpleadoRepositorie.Get();
            LoadControls(list);
        }
        public async void LoadEmpleados(int page, int elements)
        {
            list = await _EmpleadoRepositorie.Get(page,elements);
            LoadControls(list);
        }
        public async void LoadEmpleados(string name,int page, int elements)
        {
            list = await _EmpleadoRepositorie.Get(name,page, elements);
            LoadControls(list);
        }

        private void LoadControls(List<Empleado> list)
        {
            if (pnContainer.Controls.Count > 0)
            {
                pnContainer.Controls.Clear();
            }
            foreach(Empleado empleado in list)
            {
                empleado.Direccion = _DireccionRepositorie.Get(empleado.Id_Direccion).Result;
                empleado.Rol = _rolRepositorie.Get(empleado.Id_Rol).Result;
                AdapterEmpleado adapterEmpleado = new AdapterEmpleado(empleado);
                pnContainer.Controls.Add(adapterEmpleado);
                adapterEmpleado._SendEmpleado += Send_Empleado;
            }
        }
        private void Send_Empleado(Empleado empleado)
        {
            _SendEmpleado?.Invoke(empleado);
        }
    }
}
