using ApiTienda.Models.Request.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using TiendaDesktop.AccesoDatos.Concret.Compuestas;
using TiendaDesktop.AccesoDatos.Concret.Simples;
using TiendaDesktop.Core.Utilites;
using TiendaDesktop.Core.Utilites.Enums;
using TiendaDesktop.Infrastructure.Repositorie.Concret.Simples;
using TiendaDesktop.UI.Forms;
using TiendaDesktop.UI.Paneles;
using UI.Recursos.Controladores;

namespace TiendaDesktop.UI
{
    public partial class FormAddProducto : FormBack
    {
        CategoriaRepositorie CategoriaRepositorie = new CategoriaRepositorie();
        private Categoria nula;
        string imag;
        string name;
        private Producto newProducto;
        private Categoria _categoriaSeleccionada;
        private ImageRepositorie _ImageRepositorie = new ImageRepositorie();
        private ProductoRepositorie _ProductoRepositorie = new ProductoRepositorie();
        public FormAddProducto()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
           
          
            LoadCategoriasAsync();
            

        }

     

   
 

        private async void LoadCategoriasAsync()
        {
            List<Categoria> list = await CategoriaRepositorie.Get();
            nula = new Categoria();
            nula.Nombre = "-------";
            list.Insert(0, nula);
            cbxCategorias.DataSource = list;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsDataValid())
            
            {
                string ruta="";
                bool hasImage = false;
                newProducto = new Producto();
                newProducto.Nombre = pnName.Texto;
                string compra = pnCompra.Texto.Replace(".", ",");
                string venta =pnVenta.Texto.Replace(".", ",");
                newProducto.PrecioCompra = Convert.ToDecimal(compra);
                newProducto.PrecioVenta = Convert.ToDecimal(venta);
                newProducto.FechaCreacion = DateTime.Now;
                newProducto.Estado = EstadosProducto.Descativado;
                newProducto.CantidanInventario = 0;
                if (!pnInventario.IsEntyTxt())
                {
                    int cantidad = Convert.ToInt32(pnInventario.Texto);
                    newProducto.CantidanInventario = cantidad;
                }
               

               
                newProducto.Descuento = 0;
                newProducto.Categoria = _categoriaSeleccionada;
                if (!string.IsNullOrEmpty(imageFile1.GetUrl()))
                {
                    hasImage = true;
                    ruta = imageFile1.GetUrl();
                    imag = Path.GetFileName(ruta);
                    name = string.Format("{0}_{1}", newProducto.Nombre, imag);
                    newProducto.Imagen = name;
                    
                }
                int id = _ProductoRepositorie.Post(newProducto);
                if (hasImage)
                {
                    SubirImagenAsync(name, ruta);
                }
            }
         
           
        }

        private async void SubirImagenAsync(string name,string ruta)
        {
       
            if (!string.IsNullOrEmpty(ruta))
            {
                Image image = Image.FromFile(ruta);
                var ms = new MemoryStream();
                image.Save(ms, image.RawFormat);
                byte[] bytes = ms.ToArray();
                await _ImageRepositorie.Post( name, bytes);
            }


        }
        /*private async void UpdateImageAsync(string newImage)
        {

            Image image = Image.FromFile(txtRutaImage.Text);
            var ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            byte[] bytes = ms.ToArray();

            await _ImageRepositorie.Put(UrlDirectory.Imagenes, _product.Image, newImage, bytes);
        }*/
        private bool IsDataValid()
        {
            int error = 0;
            if (pnName.IsEntyTxt() )
            {
                error++;
            }
            if (pnCompra.IsEntyTxt())
            {
                error++;
            }
            if (pnVenta.IsEntyTxt())
            {
                error++;
            }
            _categoriaSeleccionada = cbxCategorias.SelectedItem as Categoria;
            if (_categoriaSeleccionada.Nombre.Equals(nula.Nombre))
            {
                error++;
            }
            if (error > 0)
            {
                return false;
            }
        
            return true;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
