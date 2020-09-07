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
    public partial class FormProducto : FormContainers
    {
        public delegate void SendMessage();
        public SendMessage OpenFormProducto;
        public FormProducto()
        {
            InitializeComponent();
            var query = "Id_Categoria_Padre is null";
            rvCategorias1.LoadCategorias(query);
            btnAdd.MouseClick += BtnAdd_MouseClick;
            rvProducts1.LoadProducts();
        }

     
        private void BtnAdd_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFormProducto.Invoke();
        }

       
    }
}
