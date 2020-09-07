using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Recursos.Controladores
{
    public class ImageControl : IImageControl
    {
        public string ImageNotFound { get ; set ; }

        public string DeleteImagen(string ruta)
        {
            if (ruta != ImageNotFound && ruta != null)
            {
                try
                {

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    File.Delete(ruta);
                }
                catch (Exception)
                {
                    return null;
                }


            }
            return null;

        }
        public string OpenFileDialogImage(PictureBox pictureBox, TextBox textBox, int maximumSize, string fileFilter, PictureBoxSizeMode sizeMode)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = fileFilter;
            pictureBox.SizeMode = sizeMode;
            return textBox.Text = OpenImageInPictureBoxMaximum(pictureBox, open, maximumSize);
        }
        public string OpenFileDialogImage(PictureBox pictureBox, TextBox textBox, int maximumSize, string fileFilter)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = fileFilter;
            return textBox.Text = OpenImageInPictureBoxMaximum(pictureBox, open, maximumSize);
        }
        public string OpenFileDialogImage(PictureBox pictureBox, TextBox textBox, int maximumSize)
        {
            OpenFileDialog open = new OpenFileDialog();
            return textBox.Text= OpenImageInPictureBoxMaximum(pictureBox, open, maximumSize);
        }
        public string OpenFileDialogImage(PictureBox pictureBox, TextBox textBox)
        {
           OpenFileDialog open = new OpenFileDialog();
            string Url = UrlFileDialog(open);
            if (Url != null)
            {
                pictureBox.Image = Image.FromFile(Url);
                textBox.Text = Url;
                return Url;
            }
            else
            {
                return null;
            }

        }
        public string OpenFileDialogImage(PictureBox pictureBox, int maximumSize, string fileFilter)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = fileFilter;
            return OpenImageInPictureBoxMaximum(pictureBox, open, maximumSize);
        }
        public string OpenFileDialogImage(PictureBox pictureBox, string fileFilter)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = fileFilter;
            return OpenImageInPictureBox(pictureBox, open);
        }
        public string OpenFileDialogImage(PictureBox pictureBox, int maximumSize)
        {
            OpenFileDialog open = new OpenFileDialog();
            return OpenImageInPictureBoxMaximum(pictureBox,open,maximumSize);
          
        }
        public string OpenFileDialogImage(PictureBox pictureBox)
        {
            OpenFileDialog open = new OpenFileDialog();
            return OpenImageInPictureBox(pictureBox,open);



        }
        public string OpenFileDialogImage(Panel panel, TextBox txtImagen, int maximumSize, string fileFilter, ImageLayout layout)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = fileFilter;
            panel.BackgroundImageLayout = layout;
            return txtImagen.Text = OpenImageInPanelMaximum(panel, open, maximumSize);
        }
        public string OpenFileDialogImage(Panel panel, TextBox txtImagen, int maximumSize, string fileFilter)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = fileFilter;
            return txtImagen.Text = OpenImageInPanelMaximum(panel,open,maximumSize);
        }
        public string OpenFileDialogImage(Panel panel, TextBox txtImagen, int maximumSize)
        {
            OpenFileDialog open = new OpenFileDialog();
            return txtImagen.Text = OpenImageInPanelMaximum(panel, open, maximumSize);
        }
        public string OpenFileDialogImage(Panel panel, TextBox txtImagen)
        {
            OpenFileDialog open = new OpenFileDialog();
            return txtImagen.Text = OpenImageInPanel(panel,open);
        }
        public string OpenFileDialogImage(Panel panel, int maximumSize, string fileFilter, ImageLayout layout)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = fileFilter;
            panel.BackgroundImageLayout = layout;
            return OpenImageInPanelMaximum(panel, open, maximumSize);

        }
        public string OpenFileDialogImage(Panel panel, int maximumSize, string fileFilter)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = fileFilter;
            return OpenImageInPanelMaximum(panel, open, maximumSize);
        }
        public string OpenFileDialogImage(Panel panel, int maximumSize)
        {
            OpenFileDialog open = new OpenFileDialog();
            return OpenImageInPanelMaximum(panel ,open, maximumSize); 
            
        }
        public string OpenFileDialogImage(Panel panel)
        {
            OpenFileDialog open = new OpenFileDialog();
            string Url = UrlFileDialog(open);
            if (Url != null)
            {
                panel.BackgroundImage = Image.FromFile(Url);
                return Url;
            }
            else
            {
                return null;
            }
        }
        public string OpenImage(PictureBox pictureBox, string UrlImage, PictureBoxSizeMode sizeMode)
        {
            pictureBox.Image = Image.FromFile(UrlImage);
            pictureBox.SizeMode = sizeMode;
            return TryOpenUrl(UrlImage);
        }
        public string OpenImage(PictureBox pictureBox, string UrlImage)
        {
            pictureBox.Image = Image.FromFile(UrlImage);
            return TryOpenUrl(UrlImage);
        }
        public string OpenImage(Panel panel, string UrlImage, ImageLayout layout)
        {
            panel.BackgroundImageLayout = layout;
            panel.BackgroundImage =Image.FromFile( TryOpenUrl(UrlImage));
            return TryOpenUrl( UrlImage);
        }
        public string OpenImage(Panel panel ,string UrlImage)
        {
           panel.BackgroundImage = Image.FromFile(TryOpenUrl(UrlImage));
           return TryOpenUrl(UrlImage);
        }
        private string TryOpenUrl(string UrlImage)
        {
            if (UrlImage != null)
            {
                if (File.Exists(UrlImage))
                {
                    return UrlImage;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
        public Image DropImage(DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);
            Image image = Image.FromFile(archivos[0]);
            return image;
        }
        public Bitmap ResizeImage(Image image, int width, int heigth)
        {
            var radio = Math.Max((double)width / image.Width,
             (double)heigth / image.Height);
            var newWidht = (int)(image.Width * radio);
            var newHeight = (int)(image.Height * radio);

            var imageResize = new Bitmap(newWidht, newHeight);
            Graphics.FromImage(imageResize).DrawImage(image, 0, 0, newWidht, newHeight);
            Bitmap _imageResized = new Bitmap(imageResize);
            return _imageResized;
        }
        public string SaveIn(string urlDirectory, string fileName, Image image)
        {
            if (image != null)
            {
                try
                {
                    Image guardar = image;
                    string rutaGuardado = Path.Combine(urlDirectory, fileName);
                    guardar.Save(Path.GetFullPath(rutaGuardado));  
                    guardar.Dispose();

                    return rutaGuardado;
                }
                catch (Exception)
                {
                    return ImageNotFound;
                }
            }
            else
            {
                return ImageNotFound;
            }
        
    }
        public string SaveIn(string urlDirectory, string fileName, string image)
        {
            if (image.Trim().Length > 0 && !image.Equals(ImageNotFound))
            {
                try
                {
                    Image guardar = Image.FromFile(image);
                    string imageName = fileName + "-" + Path.GetFileName(image);
                    string rutaGuardado = Path.Combine(urlDirectory, imageName);
                    if (Path.GetExtension(image).Equals(".gif"))
                    {
                        guardar.Save(Path.GetFullPath(rutaGuardado), System.Drawing.Imaging.ImageFormat.Gif);
                    }
                    else
                    {
                        guardar.Save(Path.GetFullPath(rutaGuardado));
                    }
                    guardar.Dispose();

                    return rutaGuardado;
                }
                catch (Exception)
                {
                    return ImageNotFound;
                }
            }
            else
            {
                return ImageNotFound;
            }
        }
        public string UpdateImagen(string urlDirectory, string fileName, string oldUrlImage, string newUrlImage)
        {
            string newFileName = fileName + "-" + Path.GetFileName(newUrlImage);
            string urlFinal = Path.GetFullPath(Path.Combine(urlDirectory, newFileName));
            if (oldUrlImage != null && newUrlImage != null && !oldUrlImage.Equals(urlFinal))
            {
                if (File.Exists(oldUrlImage))
                {
                    DeleteImagen(oldUrlImage);
                }
                return SaveIn(urlDirectory, newUrlImage, fileName);
            }
            else
            {
                return oldUrlImage;
            }
        }
        private string UrlFileDialog(OpenFileDialog open)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                string url_imagen = open.FileName;
                open.Dispose();
                return url_imagen;
            }
            else
            {
                return null;
            }
        }
        private string UrlFileDialogWithMaximun(OpenFileDialog open, int maximumSize)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                string url_imagen = open.FileName;
                long len = (new FileInfo(url_imagen)).Length;
                if (len > maximumSize)
                {
                    return null;
                }
                else
                {
                    open.Dispose();
                    return url_imagen;
                }

            }
            else
            {
                return null;
            }
        }
        private string OpenImageInPanelMaximum(Panel panel, OpenFileDialog open, int maximumSize)
        {
            string Url = UrlFileDialogWithMaximun(open, maximumSize);
            if (Url != null)
            {
                panel.BackgroundImage = Image.FromFile(Url);
                return Url;
            }
            else
            {
                return null;
            }
        }
        private string OpenImageInPanel(Panel panel, OpenFileDialog open)
        {
            string Url = UrlFileDialog(open);
            if (Url != null)
            {
                panel.BackgroundImage = Image.FromFile(Url);
                return Url;
            }
            else
            {
                return null;
            }
        }
        private string OpenImageInPictureBox(PictureBox pictureBox,OpenFileDialog open)
        {
            string Url = UrlFileDialog(open);
            if (Url != null)
            {
                pictureBox.Image = Image.FromFile(Url);
                return Url;
            }
            else
            {
                return null;
            }
        }
        private string OpenImageInPictureBoxMaximum(PictureBox pictureBox, OpenFileDialog open, int maximumSize)
        {
            string Url = UrlFileDialogWithMaximun(open, maximumSize);
            if (Url != null)
            {
                pictureBox.Image = Image.FromFile(Url);
                return Url;
            }
            else
            {
                return null;
            }
        }

      
    }
}
