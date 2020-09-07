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
using TiendaDesktop.AccesoDatos.Concret.Simples;
using TiendaDesktop.AccesoDatos.Concret.Usuarios;
using TiendaDesktop.Core.Utilites.Enums;
using TiendaDesktop.UI.Forms_Desing;
using TiendaDesktop.UI.UI_Empleados;
using TiendaDesktop.UI.UserControls.Adapter;
using UI.Recursos.Validaciones;
using WindowsFormsUI.Eventos;

namespace TiendaDesktop.UI
{
    public partial class FormEditEmpleado : FormFileEmpleado
    {
        private Rol _RolSeleccionado;
  
        private Direccion _direccion;
        private Empleado _empleado;
        private Persona _persona;
        public FormEditEmpleado()
        {

            rvRols1.LoadContent();
            rvRols1._Send += Select_Rol;
            btnSave.MouseClick += BtnSave_MouseClick;
        }
        public void SendToEdit(Empleado empleado)
        {
            _empleado = empleado;
            _direccion = empleado.Direccion;
            _persona = empleado;
            _RolSeleccionado = empleado.Rol;
            pnDate.Visible = true;

            DateTime date = Convert.ToDateTime(_empleado.Fecha_Contratacion);

            dtFechaContratacion.Value = date;
            pnDataNombre.Texto = _empleado.Nombre;
            pnDataApellido.Texto = _empleado.Apellido;
            pnDataDni.Texto = _empleado.Dni;
            pnDataPhone.Texto = _empleado.Telefono;
            pnDataEmail.Texto = _empleado.Email;
            pnDataUsername.Texto = _empleado.Username;
            pnDataPass.Texto = _empleado.Contraseña;


            pnPoblacion.Texto = _direccion.Ciudad;
            pnCodigoPostal.Texto = _direccion.CodigoPostal;
            pnDataCalle.Texto = _direccion.Calle.ToString();

            _empleado.Rol.Permisos = _PermisoRepositorie.GetByRol(_empleado.Rol.Id).Result;
            AdapterRol adapterRol = new AdapterRol(_empleado.Rol);
            pnChoisse.Controls.Add(adapterRol);
        }
        private void BtnSave_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsAllCompleted())
            {

                EditPersona();
                EditDireccion();
                _DireccionRepositorie.Put(_direccion);
     
                _empleado.Nombre = _persona.Nombre;
                _empleado.Apellido = _persona.Apellido;
                _empleado.Username = _persona.Username;
                _empleado.Contraseña = _persona.Contraseña;
                _empleado.Email = _persona.Email;
                _empleado.Telefono = _persona.Telefono;
                _empleado.Rol = _RolSeleccionado;
                _empleado.Dni = pnDataDni.Texto;
                _empleado.Tipo = _persona.Tipo;
                _empleado.Fecha_Contratacion = dtFechaContratacion.Value;
               _PersonaRepositorie.Put(_empleado);
               _EmpleadoRepositorie.Put(_empleado);

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

            if ((!pnDataDni.Texto.Equals(_empleado.Dni)))     
            {
                if (!IsValidDni())
                {
                    errores++;
                }
            }
            if (errores > 0)
            {
                return false;
            }
            return true;
        }
        private void EditPersona()
        {
            string name = pnDataNombre.Texto;
            string apellido = pnDataApellido.Texto;
            string username = pnDataUsername.Texto;
            string contraseña = pnDataPass.Texto;
            string email = pnDataEmail.Texto;
            string telefono = pnDataPhone.Texto;


            _empleado.Nombre = name;
            _empleado.Apellido = apellido;
            _empleado.Username = username;
            _empleado.Contraseña = contraseña;
            _empleado.Email = email;
            _empleado.Telefono = telefono;
            _empleado.Tipo = (int)TiposPersona.Empleado;


        }
        private void EditDireccion()
        {
            string calle = pnDataCalle.Texto;
            string poblacion = pnPoblacion.Texto;
            string codigoPostal = pnCodigoPostal.Texto;
            _direccion.Calle = calle;
            _direccion.Ciudad = poblacion;
            _direccion.CodigoPostal = codigoPostal;

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
            if (!pnDataUsername.Texto.Equals(_empleado.Username)){
                if(!IsUserNameValid(pnDataUsername.Texto)){
                    error++;
                }
            }
                
            if (!pnDataEmail.Texto.Equals(_persona.Email))
                {
                if (!IsEmailValid(pnDataEmail.Texto))
                {
                    error++;
                }
            }
            if (pnDataPass.IsEntyTxt())
            {
                error++;
            }
            if (!_empleado.Telefono.Equals(pnDataPhone.Texto))
            {
                if (!IsPhoneValid(pnDataPhone.Texto))
                {
                    error++;
                }
            }
           
            if (error > 0)
            {
                return false;
            }
            return true;
        }
   
  
   
    }
}
