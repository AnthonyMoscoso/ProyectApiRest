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
using ApiTienda.Models.Request.Abstract;
using TiendaDesktop.AccesoDatos.Concret;
using TiendaDesktop.UI.UserControls.Adapter;

namespace TiendaDesktop.UI.ReciclerViews
{
    public partial class RvClientes : ReciclerView
    {
        private ClienteRepositorie _ClienteRepositorie;
        private DireccionRepositorie _DireccionRepositorie;
        private List<Cliente> list;

        public delegate void Send(Cliente entity);
        public Send _SendEntity;

        public RvClientes()
        {
            InitializeComponent();
            _ClienteRepositorie = new ClienteRepositorie();
            _DireccionRepositorie = new DireccionRepositorie();
           
        }

        public async void LoadEntitys()
        {
            list = await _ClienteRepositorie.Get();
            LoadControls(list);
        }
        public async void LoadEntitys(int page, int elements)
        {
            list = await _ClienteRepositorie.Get(page, elements);
            LoadControls(list);
        }
        public async void LoadEntitys(string name, int page, int elements)
        {
            list = await _ClienteRepositorie.Get(name, page, elements);
            LoadControls(list);
        }

        private void LoadControls(List<Cliente> list)
        {
            if (pnContainer.Controls.Count > 0)
            {
                pnContainer.Controls.Clear();
            }
            foreach (Cliente entity in list)
            {

                AdapterCliente adapter = new AdapterCliente(entity);
                pnContainer.Controls.Add(adapter);
                adapter._SendEntity += Send_Entity;
            }
        }
        private void Send_Entity(Cliente entity)
        {
            _SendEntity?.Invoke(entity);
        }
    }
}
