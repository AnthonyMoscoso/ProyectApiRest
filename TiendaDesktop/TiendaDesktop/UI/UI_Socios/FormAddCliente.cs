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
using TiendaDesktop.AccesoDatos.Concret.Usuarios;
using TiendaDesktop.Core.Utilites.Enums;
using TiendaDesktop.UI.UI_Socios;
using UI.Recursos.Validaciones;

namespace TiendaDesktop.UI
{
    public partial class FormAddSocio : FormFileCliente
    {
        private Persona _persona;
        private Direccion _direccion;

        public FormAddSocio()
        {
            InitializeComponent();
          
            btnSave.MouseClick += BtnSave_MouseClick;
        }

        private void BtnSave_MouseClick(object sender, MouseEventArgs e)
        {
           if (IsAllCompleted())
            {

                CreatePersona();
                CreateDireccion();
                int id_direccion = _DireccionRepositorie.Post(_direccion);
                Cliente socio = new Cliente
                {
                    Nombre = _persona.Nombre,
                    Apellido = _persona.Apellido,
                    Username = _persona.Username,
                    Contraseña = _persona.Contraseña,
                    Id_Direccion = id_direccion,
                    Email = _persona.Email,
                    Telefono = _persona.Telefono,
                    Tipo = _persona.Tipo,
                    Descuento = 0
                   
                };


                int id_persona = _PersonaRepositorie.Post(socio);

                socio.Id_Persona = id_persona;

                int id_Cliente = _ClienteRepositorie.Post(socio);

            }
        }

        private bool IsAllCompleted()
        {
            int errores = 0;

            if (!IsValidDireccion())
            {
                errores++;
            }
            if (!IsValidPersonaDatas())
            {
                errores++;
            }

            if (errores > 0)
            {
                return false;
            }
            return true;
        }
        private void CreatePersona()
        {
            string name = pnDataNombre.Texto;
            string apellido = pnDataApellido.Texto;
            string username = pnDataUsername.Texto;
            string contraseña = pnDataPass.Texto;
            string email = pnDataEmail.Texto;
            string telefono = pnDataPhone.Texto;

            _persona = new Persona
            {
                Nombre = name,
                Apellido = apellido,
                Username = username,
                Contraseña = contraseña,
                Email = email,
                Telefono = telefono,
                Tipo = (int)TiposPersona.Cliente
            };

        }
        private void CreateDireccion()
        {
            string calle = pnDataCalle.Texto;
            string poblacion = pnPoblacion.Texto;  
            string codigoPostal = pnCodigoPostal.Texto;
            _direccion = new Direccion
            {
                Calle = calle,
                Ciudad = poblacion,
                CodigoPostal = codigoPostal,
                
            };
        }
         private bool IsValidPersonaDatas()
        {

            int error = 0;

            if (pnDataNombre.IsEntyTxt())
            {
                error++;
            }
            if (pnDataApellido.IsEntyTxt())
            {
                error++;
            }
            if (pnDataUsername.IsEntyTxt() || !IsUserNameValid(pnDataUsername.Texto))
            {
                error++;
            }
            if (pnDataEmail.IsEntyTxt() || !IsEmailValid(pnDataEmail.Texto))
            {
                error++;
            }
            if (pnDataPass.IsEntyTxt())
            {
                error++;
            }
            if (pnDataPhone.IsEntyTxt() || !IsPhoneValid(pnDataPhone.Texto))
            {
                error++;
            }
            if (error > 0)
            {
                return false;
            }
            return true;
        }
    
  
       
    }
}
