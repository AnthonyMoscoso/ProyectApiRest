using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDesktop.UI.Forms;
using ApiTienda.Models.Request.Concret;
using TiendaDesktop.Core.Utilites.Enums;
using ApiTienda.Models.Request.Abstract;
using TiendaDesktop.AccesoDatos.Concret.Usuarios;
using TiendaDesktop.AccesoDatos.Concret;
using TiendaDesktop.Core.Utilites.FormatosTexto;
using TiendaDesktop.AccesoDatos.Concret.Compuestas;
using TiendaDesktop.AccesoDatos.Concret.Conexiones;
using System.Diagnostics.Eventing.Reader;

namespace TiendaDesktop.UI.Fichas
{
    public partial class FormCompra : FormBack
    {
        private PersonaRepositorie _PersonaRepositorie;
        private ClienteRepositorie _ClienteRepositorie;
        private EmpleadoRepositorie _EmpleadoRepositorie;
        private CompraRepositorie _CompraRepositorie;
        private LineaCompraRepositorie _LineaCompraRepositorie;

        private List<LineaCompra> Carrito;
        private FormasDePago metodoDePago=FormasDePago.Efectivo;
        private Persona Comprador=null;
        private Cliente _clienteComprador=null;
        private Empleado _empleadoComprador;

        private Empleado vendedor;
        private decimal Descuento=0;
        private decimal total;
       
        public FormCompra()
        {
            InitializeComponent();
            rbEfectivo.CheckedChanged += RbEfectivo_CheckedChanged;
            rbTarjeta.CheckedChanged += RbTarjeta_CheckedChanged;
            btnSearch.MouseClick += BtnSearch_MouseClick;
            _PersonaRepositorie = new PersonaRepositorie();
            rbAcumular.CheckedChanged += RbAcumular_CheckedChanged;
            rbUsar.CheckedChanged += RbUsar_CheckedChanged;
            btnCompra.MouseClick += BtnCompra_MouseClick;
            

        }

        public void SetVendedor(Empleado empleado)
        {
            vendedor = empleado;
        }

        private void BtnCompra_MouseClick(object sender, MouseEventArgs e)
        {
            Compra compra = new Compra
            {
                LineaCompras = Carrito,
                Id_Comprador = Comprador.Id,
                Fecha = DateTime.Now,
                FormaPago = metodoDePago,
                Descuento = Descuento,
                Id_Vendedor=vendedor.Id
            };

            _CompraRepositorie = new CompraRepositorie();
            _LineaCompraRepositorie = new LineaCompraRepositorie();

            int id = _CompraRepositorie.Post(compra);
            foreach (LineaCompra linea in  Carrito)
            {
                linea.Id_Compra = id;
                _LineaCompraRepositorie.Post(linea);
            }
        }

        private void RbUsar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsar.Checked && Comprador!=null)
            {
                CalcularDescuento();
            }
        }

     

        private void RbAcumular_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAcumular.Checked && Comprador!=null)
            {
                ShowPrecioDescuento();
            }
        }

        private void CalcularDescuento()
        {
            if (Comprador.Tipo == (int)TiposPersona.Cliente)
            {
                _ClienteRepositorie = new ClienteRepositorie();
                try
                {
                    _clienteComprador = _ClienteRepositorie.Get(Comprador.Id).Result;
                    Descuento = _clienteComprador.Descuento;
                    if (Descuento > 0)
                    {
                        ShowPrecioDescuento();
                    }
                }
                catch
                {

                }
            }
          
        }
        private void BtnSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (!pnEmail.IsEntyTxt())
            {
                var query = string.Format("Email='{0}'", pnEmail.Texto);
                Comprador = _PersonaRepositorie.GetWhere(query).Result;
                if (Comprador != null)
                {
                    if (Comprador.Tipo == (int)TiposPersona.Cliente)
                    {
                        CalcularDescuento();
                    }
                    else
                    {
                        _EmpleadoRepositorie = new EmpleadoRepositorie();
                        try
                        {
                            _empleadoComprador = _EmpleadoRepositorie.Get(Comprador.Id).Result;
                            Descuento = 0.15M * total;
                            ShowPrecioDescuento();

                        }
                        catch
                        {

                        }
                    }
                }
                else
                {
                    pnEmail.SetErrorMessage("No se ha encontrado ningun resultado con este email");
                }
            }
            else
            {
                pnEmail.SetErrorMessage("introduzca un email de usuario");
            }
        }

        private void ShowPrecioDescuento()
        {
            if (Descuento>0)
            {
                lbDescuento.Text = Descuento + "€";
                lbFinal.Text = string.Format("{0}€", total - Descuento);
                FormatosTexto.CambiarFormato(lbTotal, false, false, true, false);
            }
            else
            {
                lbDescuento.Text = 0 + "€";
                lbFinal.Text = total.ToString()+"€" ;
                FormatosTexto.CambiarFormato(lbTotal,false,false,false,false);
            }
           
        }

        private void RbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTarjeta.Checked)
            {
                metodoDePago = FormasDePago.Tarjeta;
            }
          
        }

        private void RbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked)
            {
                metodoDePago = FormasDePago.Efectivo;
            }
        }

        public void LoadCompra(List<LineaCompra>list)
        {
            Carrito = list;
            foreach (LineaCompra linea in list){
                rvLineaCompra1.Add_ELEMENT(linea);
                rvLineaCompra1._Less +=Edit_Cantidad;
                rvLineaCompra1._More +=Edit_Cantidad;
                rvLineaCompra1._Remove+=Get_Remove;
            }
            Calcular();
        }

        private void Get_Remove(LineaCompra linea)
        {
            Carrito.Remove(linea);
            Calcular();

        }
        private void Edit_Cantidad(LineaCompra linea)
        {
            foreach (LineaCompra l in Carrito)
            {
                if (l.Equals(linea))
                {
                    l.Cantidad = linea.Cantidad;
                    Calcular();
                    break;
                }
            }
        }
        private void Calcular()
        {
             total = 0;
            foreach (LineaCompra linea in Carrito)
            {
                decimal precio = linea.Precio * linea.Cantidad;
                total += precio;
            }
            lbTotal.Text = string.Format("Total :{0}", total);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
