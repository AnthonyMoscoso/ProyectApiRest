using ApiTienda.Models.Request.Abstract;
using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDesktop.AccesoDatos.Concret;
using TiendaDesktop.Core.Utilites;
using TiendaDesktop.Core.Utilites.Strings;
using TiendaDesktop.Models;
using TiendaDesktop.Services.Concret;
using TiendaDesktop.UI.Fichas;
using TiendaDesktop.UI.Paneles;
using TiendaDesktop.UI.UI_Socios;

namespace TiendaDesktop.UI
{
    public partial class FormApp : Form
    {
        private List<Button> buttons = new List<Button>();

        private DireccionRepositorie _repositorie= new DireccionRepositorie();
        public FormApp()
        {
            InitializeComponent();
            imgLogo.BackColor = ListaColores.BACKGROUND;
            btnMenu.Click += BtnMenu_Click;
            buttons.Add(btnInventario);
            buttons.Add(btnEmpleados);
            buttons.Add(btnSocios);
            buttons.Add(btnPedidos);
            buttons.Add(btnCaja);
            buttons.Add(btnCategorias);
            buttons.Add(btnFacturas);

            pnLeft.BackColor = ListaColores.BACKGROUND;
            btnCategorias.MouseClick += BtnCategorias_MouseClick;
            btnInventario.MouseClick += BtnInventario_MouseClick;
            btnSocios.MouseClick += BtnSocios_MouseClick;
        }

        private void BtnSocios_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            FormClientes form = new FormClientes();
            OpenForm(form);
            BottonSetting(button);
            form._openForm += OpenForm_FileCliente;
        }

        private void OpenForm_FileCliente(Cliente cliente)
        {
            if (cliente!=null)
            {
                
            }
            else
            {
                FormAddSocio form = new FormAddSocio();
                OpenForm(form);
            }
        }
        private void BtnInventario_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            BottonSetting(button);
            Open_Inventario();
        }
        private void Open_Inventario()
        {
            FormProducto form = new FormProducto();
            OpenForm(form);
    
            form.OpenFormProducto += Open_FormProducto;
        }

        private void BottonSetting(Button button)
        {
            foreach (Button b in buttons)
            {
                if (b==button){
                    b.Enabled = false;
                }
                else
                {
                    b.Enabled = true;
                }
            }
        }
        private void Open_FormProducto()
        {
            FormAddProducto form = new FormAddProducto();
            OpenForm(form);
            form._sendBack += Open_Inventario;
        }
        private void OpenForm(object formHijo)
        {
            if (pnContainer.Controls.Count > 0)
            {
                pnContainer.Controls[0].Dispose();
                pnContainer.Controls.Clear();

            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            pnContainer.Controls.Add(fh);
            pnContainer.Tag = fh;
            fh.Show();
            fh.Resize += Fh_Resize;
        }

        private void Fh_Resize(object sender, EventArgs e)
        {
            Form f = sender as Form;
          
        }

        private void BtnCategorias_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            FormCategorias form = new FormCategorias();
            OpenForm(form);
            form.LoadCategoriasWithMenu();
            BottonSetting(button);
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (pnLeft.Width ==190)
            {
                pnLeft.Width = 80;
                foreach(Button b in buttons)
                {
                    b.Text = "";
                }
            }
            else
            {
                btnInventario.Text = StringList.INVENTARIO;
                btnFacturas.Text = StringList.FACTURAS;
                btnEmpleados.Text = StringList.EMPLEADOS;
                btnPedidos.Text = StringList.PEDIDOS;
                btnSocios.Text = StringList.SOCIOS;
                btnCaja.Text = StringList.CAJA;
                btnCategorias.Text = StringList.CATEGORIAS;
                btnFacturas.Text = StringList.FACTURAS;

                pnLeft.Width = 190;
            }
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Open_Empleados();
            BottonSetting(button);
        }

        private void Open_Empleados()
        {
            FormEmpleados form = new FormEmpleados();
            OpenForm(form);
            form._openForm += Open_AddEmpleados;
        }
        private void Open_AddEmpleados(Empleado empleado)
        {
            
            if (empleado==null)
            {
                FormAddEmpleado form = new FormAddEmpleado();
                OpenForm(form);
                form._sendBack += Open_Empleados;
            }
            else
            {
                FormEditEmpleado form = new FormEditEmpleado();
                OpenForm(form);
                form._sendBack += Open_Empleados;
                form.SendToEdit(empleado);

            }
            
            
           
        }

        private void BtnCaja_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            FormCaja form = new FormCaja();
            OpenForm(form);
            form._send += Open_Compra;
            BottonSetting(button);
        }

        private void Open_Compra(List<LineaCompra> carrito)
        {
            FormCompra form = new FormCompra();
            OpenForm(form);
            form.SetVendedor(null);
            form.LoadCompra(carrito);
        }
    }
}
