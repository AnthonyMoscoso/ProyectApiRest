using TiendaDesktop.Core.Utilites;

namespace System.Windows.Forms
{
    internal class AlertPictureBox : PictureBox
    {

        public AlertPictureBox()
        {

            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.Size = new Drawing.Size(15, 15);
            this.Visible = false;

        }
        public void SetErrorMessage(string Message)
        {
            this.Visible = true;
            this.Image = ImagenesResources.ALERT;
            new ToolTip().SetToolTip(this, Message);

        }
        public void IsCorrect()
        {

            this.Visible = false;
        }
    }
}
