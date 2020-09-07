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
using ApiTienda.Models.Request.Concret;
using TiendaDesktop.UI.UserControls.Adapter;

namespace TiendaDesktop.UI.Views
{
    public partial class RvLineaCompra : ReciclerView
    {
        public delegate void Send(LineaCompra linea);

   
        public Send _Less;
        public Send _More;
        public Send _Remove;

        public RvLineaCompra()
        {
            InitializeComponent();
        }

        public void Add_ELEMENT(LineaCompra line)
        {
            AdapterLineaCompra adapter = new AdapterLineaCompra(line);
            adapter.Width = pnContainer.Width - 60;
            pnContainer.Controls.Add(adapter);
            adapter._Less += Send_Less;
            adapter._More += Send_More;
            adapter._Remove += Send_Remove;
        }
        public void Clear()
        {
            pnContainer.Controls.Clear();
        }

        public void Send_Less(LineaCompra linea)
        {
            _Less?.Invoke(linea);
        }
        public void Send_More(LineaCompra linea)
        {
            _More?.Invoke(linea);
        }
        public void Send_Remove(LineaCompra linea)
        {
            _Remove?.Invoke(linea);
        }
    }
}
