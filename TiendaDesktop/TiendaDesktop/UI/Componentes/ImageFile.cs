using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Recursos.Controladores;
using TiendaDesktop.Core.Utilites;

namespace TiendaDesktop.UI.Componentes
{
    public partial class ImageFile : UserControl
    {
        public ImageFile()
        {
            InitializeComponent();
            pnImage.MouseClick += PnImage_MouseClick;
            btnCancelImage.MouseClick += BtnCancelImage_MouseClick;

        }

        private void BtnCancelImage_MouseClick(object sender, MouseEventArgs e)
        {
            txtRutaImage.Clear();
            pnImage.BackgroundImage = ImagenesResources.NOT_IMAGE;
            btnCancelImage.Visible = false;
            btnCancelImage.Enabled = false;
        }

        private void PnImage_MouseClick(object sender, MouseEventArgs e)
        {
            ImageControl imageControl = new ImageControl();
            imageControl.OpenFileDialogImage(pnImage, txtRutaImage);
            btnCancelImage.Visible = true;
            btnCancelImage.Enabled = true;
        }

        public string GetUrl()
        {
            return txtRutaImage.Text;
        }
    }
}
