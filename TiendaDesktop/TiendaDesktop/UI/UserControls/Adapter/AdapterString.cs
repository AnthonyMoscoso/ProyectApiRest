using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDesktop.UI.UserControls.Adapter
{
    public partial class AdapterString : UserControl
    {
        public Image PictureImage { get; set; }
        public string Texto { get; set; }
        public AdapterString()
        {
            InitializeComponent();
            Paint += AdapterString_Paint;
            lbName.MouseEnter += Label1_MouseEnter;
            lbName.MouseLeave += Label1_MouseLeave;
        }

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            this.Padding = new Padding(8);
        }

        private void Label1_MouseEnter(object sender, EventArgs e)
        {
            this.Padding = new Padding(5);
        }

        private void AdapterString_Paint(object sender, PaintEventArgs e)
        {
            if (PictureImage != null)
            {
                ptImage.Image = PictureImage;
            }
            if (!string.IsNullOrEmpty(Texto))
            {
                lbName.Text = Texto;
            }
            
        }
    }
}
