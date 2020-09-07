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
using TiendaDesktop.AccesoDatos.Concret.Compuestas;
using TiendaDesktop.AccesoDatos.Concret.Conexiones;

namespace TiendaDesktop.UI.UserControls.Adapter
{
    public partial class AdapterFactura : UserControl
    {
        CompraRepositorie CompraRepositorie = new CompraRepositorie();
        LineaCompraRepositorie LineaCompraRepositorie = new LineaCompraRepositorie();
        List<LineaCompra> lineaCompras = new List<LineaCompra>();

        public AdapterFactura()
        {
            InitializeComponent();
        }

        public void SetVenta(Compra compra )
        {
            lineaCompras = LineaCompraRepositorie.GetByIdCompra(compra.Id).Result;
            compra.LineaCompras = lineaCompras;
            dataGridView1.DataSource = lineaCompras;

        }
    }
}
