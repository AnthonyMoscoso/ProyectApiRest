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
using UI.Recursos.Validaciones;

namespace TiendaDesktop.UI.UI_Socios
{
    public partial class FormFileCliente : FormPersona
    {
        public PersonaRepositorie _PersonaRepositorie;
        public DireccionRepositorie _DireccionRepositorie;
        public ClienteRepositorie _ClienteRepositorie;
        public FormFileCliente()
        {
            InitializeComponent();
            _PersonaRepositorie = new PersonaRepositorie();
            _DireccionRepositorie = new DireccionRepositorie();
            _ClienteRepositorie = new ClienteRepositorie();
 
        }

  
        public bool IsValidDireccion()
        {
            int error = 0;
            if (pnPoblacion.IsEntyTxt())
            {
                error++;
            }
            if (pnCodigoPostal.IsEntyTxt())
            {
                error++;
            }

            if (pnDataCalle.IsEntyTxt())
            {
                error++;
            }
            if (error > 0)
            {
                return false;
            }
            return true;
        }
        public bool IsPhoneValid(string phone)
        {
            if (_PersonaRepositorie.ExistPhone(phone).Result)
            {
                pnDataEmail.SetErrorMessage("Ya existe un usuario con este nombre registrado");
                return false;

            }
            return true;
        }
        public bool IsEmailValid(string email)
        {
            if (!ValidarEmail.IsValidEmail(email))
            {
                pnDataEmail.SetErrorMessage("formato de email incorrecto");
            }
            else
            {
                if (_PersonaRepositorie.ExistEmail(email).Result)
                {
                    pnDataEmail.SetErrorMessage("Ya existe una persona registrada con este email");

                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsUserNameValid(string username)
        {
            if (_PersonaRepositorie.ExistUsername(username).Result)
            {
                pnDataUsername.SetErrorMessage("Ya existe una persona con este nombre de usuario");
                return false;
            }
            return true;
        }
    }
}
