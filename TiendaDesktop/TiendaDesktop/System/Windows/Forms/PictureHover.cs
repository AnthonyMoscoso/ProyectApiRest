using System.Drawing;

namespace System.Windows.Forms
{
    internal class PictureHover : PictureBox
    {

        public Image ImageInicial;
        public bool Hover { get; set; }
        public bool Clicked { get; set; }
        public Padding MarginIn;

        public Image ImageHover
        {
            get; set;
        }

        public Padding MargingOut { get; set; }
        public PictureHover()
        {

            this.MouseEnter += PictureHover_MouseEnter;
            this.MouseLeave += PictureHover_MouseLeave;
            this.MouseClick += PictureHover_MouseClick;
            this.SizeMode = PictureBoxSizeMode.Zoom;


        }

        private void PictureHover_MouseClick(object sender, MouseEventArgs e)
        {
            if (Clicked)
            {
                if (Image == ImageHover)
                {
                    Image = ImageInicial;
                }
                else
                {
                    Image = ImageHover;
                }
            }

        }

        public void Run()
        {

        }

        private void PictureHover_MouseLeave(object sender, EventArgs e)
        {
            if (Hover)
            {
                if (ImageInicial != null && !Clicked)
                {
                    this.Image = ImageInicial;

                }
                if (MarginIn == null)
                {
                    this.Margin = new Padding(6);
                }
                else
                {
                    this.Margin = MarginIn;
                }


            }


        }

        private void PictureHover_MouseEnter(object sender, EventArgs e)
        {
            MarginIn = this.Margin;
            if (ImageInicial == null)
            {
                this.ImageInicial = this.Image;
            }
            if (Hover)
            {
                if (ImageHover != null && !Clicked)
                {
                    this.Image = ImageHover;
                }
                if (MargingOut == null)
                {
                    this.Margin = new Padding(3);
                }
                else
                {
                    this.Margin = MargingOut;
                }


            }

        }
    }
}