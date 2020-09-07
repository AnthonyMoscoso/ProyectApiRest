using ApiTienda.Models.Request.Abstract;
using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDesktop.AccesoDatos.Concret;
using TiendaDesktop.AccesoDatos.Concret.Usuarios;
using TiendaDesktop.Core.Utilites.Enums;
using TiendaDesktop.UI.Forms_Desing;
using TiendaDesktop.UI.UI_Empleados;
using TiendaDesktop.UI.UserControls.Adapter;
using UI.Recursos.Validaciones;
using WindowsFormsUI.Eventos;

namespace TiendaDesktop.UI
{
    public partial class FormAddEmpleado : FormFileEmpleado
    {

        private Direccion _direccion;
        private Persona _persona;
        public FormAddEmpleado()
        {
            InitializeComponent();
            _PersonaRepositorie = new PersonaRepositorie();
            _DireccionRepositorie = new DireccionRepositorie();
            _EmpleadoRepositorie = new EmpleadoRepositorie();
            rvRols1.LoadContent();
            rvRols1._Send += Select_Rol;
            btnSave.MouseClick += BtnSave_MouseClick;
            
           
        }
        private void BtnSave_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsAllCompleted())
            {
                CreatePersona();
                CreateDireccion();
                int id_direccion = _DireccionRepositorie.Post(_direccion);
                Empleado empleado = new Empleado();
                empleado.Nombre = _persona.Nombre;
                empleado.Apellido = _persona.Apellido;
                empleado.Username = _persona.Username;
                empleado.Contraseña = _persona.Contraseña;
                empleado.Id_Direccion = id_direccion;
                empleado.Email = _persona.Email;
                empleado.Telefono = _persona.Telefono;

                empleado.Rol = _RolSeleccionado;
             
                empleado.Dni = pnDataDni.Texto;
                empleado.Tipo = _persona.Tipo;

                int id_persona = _PersonaRepositorie.Post(empleado);

                empleado.Id_Persona = id_persona;
                int id_empleado = _EmpleadoRepositorie.Post(empleado);
            }
        
            
        }
        private bool IsAllCompleted()
        {
            int errores = 0;
            if (_RolSeleccionado == null)
            {
                errores++;
              
            }
        
            if (!IsValidDireccion())
            {
                errores++;
            }
            if (!IsValidPersonaDatas())
            {
                errores++;
            }
            if (!IsValidDni())
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
                Tipo= (int)TiposPersona.Empleado
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

            if (pnDataNombre.IsEntyTxt() )
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
            if (pnDataPhone.IsEntyTxt() || !IsPhoneValid(pnDataPhone.Texto) )
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
