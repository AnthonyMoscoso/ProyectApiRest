using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDesktop.Models.Abstractas;

namespace TiendaDesktop.Core.Utilites.UI.Paneles
{
    public partial class ReciclerView : UserControl
    {
        
        public ReciclerView()
        {
            InitializeComponent();
        }

        public void setList<T>(List<T> list,CardAdapter adapter)
        {
            foreach (T entity in list)
            {
                adapter._selectItem += Return_selectItem;
                pnContainer.Controls.Add(adapter);
               
            }
        }

        public void Return_selectItem(object o)
        {

        }
    }
}
