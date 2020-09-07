using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDesktop.Core.Utilites.UI.Paneles;
using TiendaDesktop.AccesoDatos.Concret.Conexiones;
using TiendaDesktop.AccesoDatos.Repositorie.Concret.Simples;
using ApiTienda.Models.Request.Concret;
using TiendaDesktop.UI.UserControls.Adapter;
using ApiTienda.Models.Request.Abstract;
using TiendaDesktop.AccesoDatos.Concret.Simples;

namespace TiendaDesktop.UI.View
{
    public partial class RvRols : ReciclerView
    {
        private RolRepositorie _RolRepositorie;
        private PermisoRepositorie _permisoRepositorie;
        private List<Rol> list;
        public delegate void SendEntity(Rol rol);
        public SendEntity _Send;

        public RvRols()
        {
            InitializeComponent();
            _RolRepositorie = new RolRepositorie();
            _permisoRepositorie = new PermisoRepositorie();
           
        }

        public async void LoadContent()
        {
                list = await _RolRepositorie.Get();
                LoadPanels(list);
        }
        private async void LoadPanels(List<Rol> list)
        {
            if (pnContainer.Controls.Count > 0)
            {
                pnContainer.Controls.Clear();
            }
            foreach (Rol entity in list)
            {
                entity.Permisos = await _permisoRepositorie.GetByRol(entity.Id);
                AdapterRol adapter = new AdapterRol (entity);
                pnContainer.Controls.Add(adapter);
                adapter._SendElement += Send_Element;
                adapter._SendToDelete += Delete_entity;
          
            }
        }

        private void Delete_entity(Rol rol)
        {
            _RolRepositorie.Delete(rol);
        }
        private void Send_Element(Rol rol)
        {
            _Send(rol);
        }
    }
}
