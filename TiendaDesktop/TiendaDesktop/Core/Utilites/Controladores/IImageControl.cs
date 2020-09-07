using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Recursos.Controladores
{
    public interface IImageControl
    {
        //Open an image in a picturebox using an OpenFileDialog , Write the URL in the textbox, , maximum image size with filter 
       string OpenFileDialogImage(PictureBox pictureBox, TextBox textBox, int maximumSize, string fileFilter, PictureBoxSizeMode sizeMode);
        string OpenFileDialogImage(PictureBox pictureBox, TextBox textBox, int maximumSize, string fileFilter);
        string OpenFileDialogImage(PictureBox pictureBox, TextBox textBox, int maximumSize);
        string OpenFileDialogImage(PictureBox pictureBox, TextBox textBox);
        //without textbox
        string OpenFileDialogImage(PictureBox pictureBox, int maximumSize, string fileFilter);
        string OpenFileDialogImage(PictureBox pictureBox, string filteFilter);
        string OpenFileDialogImage(PictureBox picture, int maximumSize);
        //alone
        string OpenFileDialogImage(PictureBox pictureBox);

        //Open an image in a picturebox using an OpenFileDialog , Write the URL in the textbox, maximum image size with filter and layoutImagen
        string OpenFileDialogImage(Panel panel, TextBox txtImagen, int maximumSize, string fileFilter, ImageLayout layout);
        string OpenFileDialogImage(Panel panel, TextBox txtImagen, int maximumSize, string fileFilter);
        string OpenFileDialogImage(Panel panel, TextBox txtImagen, int maximumSize);
        string OpenFileDialogImage(Panel panel, TextBox txtImagen);

        //without textbox
       string OpenFileDialogImage(Panel panel, int maximumSize, string fileFilter, ImageLayout layout);
        string OpenFileDialogImage(Panel panel, int maximumSize, string fileFilter);
        string OpenFileDialogImage(Panel panel, int maximumSize);
        string OpenFileDialogImage(Panel panel);


        //Open an image in a picturebox Through it's url
        string OpenImage(PictureBox pictureBox, string UrlImage, PictureBoxSizeMode sizeMode);
        string OpenImage(PictureBox pictureBox, string UrlImage);

        //Open an image in a Panel Through it's url
        string OpenImage(Panel panel, string UrlImage, ImageLayout layout);
        string OpenImage(Panel panel, string UrlImage);

        //Resize Image
        Bitmap ResizeImage(Image image, int width, int heigth);

        //Save image  in the Url  
        string SaveIn(string urlDirectory, string fileName, Image image);
        string SaveIn(string urlDirectory, string fileName, string image);

        //Update Image
        string UpdateImagen(string urlDirectory, string fileName, string oldUrlImage, string newUrlImage);

        //Delete Image
        string DeleteImagen(string ruta);

       string ImageNotFound { get; set; }
        //Drag and Drop Image

        Image DropImage( DragEventArgs e);
    }
        
      
    
}
