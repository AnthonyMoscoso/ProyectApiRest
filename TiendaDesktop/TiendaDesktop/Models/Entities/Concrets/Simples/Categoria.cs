using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using TiendaDesktop.Models;
using TiendaDesktop.Models.Abstractas;

namespace ApiTienda.Models.Request.Abstract
{
    public class Categoria : IEntidad
    {
        public int Id { get; set; }
        public int? Id_Categoria_Padre
        {
            get {
                return Categoria_Padre != null ? Categoria_Padre.Id : IdPadre; }
            set {


                IdPadre = value;
                
            }
      
        }

          
             
          public int? IdPadre;  
                
        public Categoria Categoria_Padre { get; set; }
        public string Nombre { get; set; }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Categoria p = (Categoria)obj;
                return (Nombre == p.Nombre );
            }
        }
        public override string ToString()
        {
            return this.Nombre;
        }
    }
}