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
using TiendaDesktop.AccesoDatos.Concret.Simples;
using TiendaDesktop.AccesoDatos.Concret.Usuarios;
using TiendaDesktop.UI.Forms_Desing;
using TiendaDesktop.UI.UserControls.Adapter;
using UI.Recursos.Validaciones;
using WindowsFormsUI.Eventos;

namespace TiendaDesktop.UI.UI_Empleados
{
    public partial class FormFileEmpleado : FormEmpleadoDesing
    {
        public Rol _RolSeleccionado;
        public PersonaRepositorie _PersonaRepositorie;
        public DireccionRepositorie _DireccionRepositorie;
        public EmpleadoRepositorie _EmpleadoRepositorie;
        public PermisoRepositorie _PermisoRepositorie;
        public FormFileEmpleado()
        {
            InitializeComponent();

            _PersonaRepositorie = new PersonaRepositorie();
            _DireccionRepositorie = new DireccionRepositorie();
            _EmpleadoRepositorie = new EmpleadoRepositorie();
            _PermisoRepositorie = new PermisoRepositorie();
        }

        public bool IsValidDni()
        {
            if (!pnDataDni.IsEntyTxt())
            {
                if (ValidarDni.Valida_NIFCIFNIE(pnDataDni.Texto))
                {
                    bool exist = _EmpleadoRepositorie.ExistDni(pnDataDni.Texto).Result;
                    if (!exist)
                    {
                        return true;
                    }
                    else
                    {
                        pnDataDni.SetErrorMessage("Ya existe un usuario con este dni");
                    }
                }
                else
                {
                    pnDataDni.SetErrorMessage("El dni no es valido");
                }

            }

            return false;
        }

        public bool IsPhoneValid(string phone)
        {
            if (!pnDataPhone.IsEntyTxt())
            {
                if (_PersonaRepositorie.ExistPhone(phone).Result)
                {
                    pnDataEmail.SetErrorMessage("Ya existe un usuario con este numero registrado");
                    return false;

                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }


        }

        public bool IsEmailValid(string email)
        {
            if (!pnDataEmail.IsEntyTxt())
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
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                }

            }
            return false;


        }

        public bool IsUserNameValid(string username)
        {
            if (!pnDataUsername.IsEntyTxt())
            {
                if (_PersonaRepositorie.ExistUsername(username).Result)
                {
                    pnDataUsername.SetErrorMessage("Ya existe una persona con este nombre de usuario");
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }

        }


        public void Select_Rol(Rol rol)
        {
            _RolSeleccionado = rol;
            if (pnChoisse.Controls.Count > 0)
            {
                pnChoisse.Controls.Clear();
            }
            AdapterRol adapterRol = new AdapterRol(_RolSeleccionado);
            pnChoisse.Controls.Add(adapterRol);
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
    }
}
