using ApiTienda.Models;
using ApiTienda.Models.Request.Abstract;
using ApiTienda.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Web;

namespace ApiTienda.Repositories.Concrets.Usuarios
{
    public class EmpleadoRepositorie : IEmpleadoRepositorie
    {
        private static string SELECT_INNER_JOIN = "select * from Empleado inner join Persona on Persona.Id = {0} ;";
        private static string SELECT_INNER_JOIN_FILTER = "select * from Empleado inner join Persona on Persona.Id=Empleado.Id_Persona where {0} ;";
        private static string SELECT_INNER_JOIN_WHERE_DNI = "select * from Empleado inner join Persona on Persona.Id=Empleado.Id_Persona where dni= '{0}' ;";
        public int Count()
        {
            int count = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    count = db.Empleado.Count();
                }
            }
            catch (IOException)
            {

            }
            return count;
        }

        public int Count(string filter)
        {
            int count = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    string query = string.Format("select * from  Empleado {0}", filter);
                    var result = db.Empleado.SqlQuery(query).Count();
                    count = result;
                }
            }
            catch (IOException)
            {

            }
            return count;
        }

        public string Delete(int id)
        {
            try
            {
                Empleado Entity;
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    if ((Entity = db.Empleado.Find(id)) != null)
                    {
                        db.Empleado.Remove(Entity);
                        db.SaveChanges();
                    }
                    else
                    {
                        return ("No existe ningun item con este Id");
                    }

                }
                return ("Correct");
            }
            catch (DbUpdateException)
            {
                return ("no puede borrar un item que esta en uso");
            }
            catch (IOException)
            {
                return ("Error al introducir en la base de datos");
            };
        }
        public List<EmpleadoRequest> Get()
        {
            List<EmpleadoRequest> list = new List<EmpleadoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_INNER_JOIN, "  Empleado.Id_Persona ");
                list = (from d in db.Empleado.SqlQuery(query)
                        select new EmpleadoRequest
                        {
                            Id = d.Persona.Id,
                            Nombre = d.Persona.Nombre,
                            Apellido = d.Persona.Apellido,
                            Username = d.Persona.Username,
                            Contraseña = d.Persona.Contraseña,
                            Id_Direccion = d.Persona.Id_Direccion,
                            Tipo = d.Persona.Tipo,
                            Telefono = d.Persona.Telefono,
                            Email = d.Persona.Email,
                            Id_Persona = d.Id_Persona,
                            Dni = d.Dni,
                            Id_Rol=d.Id_Rol,
                            Fecha_Contratacion=d.Fecha_Contratacion,
                            Fecha_Despido= d.Fecha_Despido


                        }).ToList();
            }
            return list;
        }

        public bool ExistDni(string dni)
        {
            EmpleadoRequest _Entity = new EmpleadoRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                try
                {
                    _Entity = (from d in db.Empleado
                               where d.Dni==dni
                               select new EmpleadoRequest()
                               ).First();
                    if (_Entity != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (
                InvalidOperationException)
                {
                    return false;
                }

            }
        }

        public bool ExistDni(int id, string dni)
        {
            EmpleadoRequest _Entity = new EmpleadoRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                try
                {
                    _Entity = (from d in db.Empleado
                               where d.Dni == dni && d.Id_Persona ==id
                               select new EmpleadoRequest()
                               ).First();
                    if (_Entity != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (
                InvalidOperationException)
                {
                    return false;
                }

            }
        }

        public List<EmpleadoRequest> Get(int page, int elements)
        {
            List<EmpleadoRequest> list = new List<EmpleadoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_INNER_JOIN, "  Empleado.Id_Persona ");
                list = (from d in db.Empleado.SqlQuery(query)
                        orderby d.Persona.Nombre
                        select new EmpleadoRequest
                        {
                            Id = d.Persona.Id,
                            Nombre = d.Persona.Nombre,
                            Apellido = d.Persona.Apellido,
                            Username = d.Persona.Username,
                            Contraseña = d.Persona.Contraseña,
                            Id_Direccion = d.Persona.Id_Direccion,
                            Tipo = d.Persona.Tipo,
                            Telefono = d.Persona.Telefono,
                            Email = d.Persona.Email,
                            Id_Persona = d.Id_Persona,
                            Dni = d.Dni,
                            Id_Rol = d.Id_Rol,
                            Fecha_Contratacion= d.Fecha_Contratacion,
                            Fecha_Despido= (DateTime)d.Fecha_Despido
                            


                        }).Skip(page).Take(elements).ToList();
            }
            return list;
        }

        public EmpleadoRequest Get(int id)
        {
            EmpleadoRequest Entity;
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_INNER_JOIN, id);
                Entity = (from d in db.Empleado.SqlQuery(query)
                          select new EmpleadoRequest
                          {
                              Id = d.Persona.Id,
                              Nombre = d.Persona.Nombre,
                              Apellido = d.Persona.Apellido,
                              Username = d.Persona.Username,
                              Contraseña = d.Persona.Contraseña,
                              Id_Direccion = d.Persona.Id_Direccion,
                              Tipo = d.Persona.Tipo,
                              Telefono = d.Persona.Telefono,
                              Email = d.Persona.Email,
                              Id_Persona = d.Id_Persona,
                              Dni = d.Dni,
                              Id_Rol = d.Id_Rol,
                              Fecha_Contratacion = d.Fecha_Contratacion,
                              Fecha_Despido = (DateTime)d.Fecha_Despido

                          }).First();
            }
            return Entity;
        }

        public int Post(EmpleadoRequest Entity)
        {
            Empleado _Entity;

            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    _Entity = new Empleado
                    {
                        Id_Persona = Entity.Id_Persona,
                        Descuento = Entity.Descuento,
                        Dni=Entity.Dni,
                        Id_Rol=Entity.Id_Rol,
                     
                        Fecha_Contratacion=DateTime.Now
                    };

                    db.Empleado.Add(_Entity);
                    db.SaveChanges();

                }
                return (_Entity.Id_Persona);
            }
         
            catch (IOException)
            {
                return 0;
            }
        }

        public List<EmpleadoRequest> Get(string var)
        {
            List<EmpleadoRequest> list = new List<EmpleadoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_INNER_JOIN_FILTER, var);
                list = (from d in db.Empleado.SqlQuery(query)
                        select new EmpleadoRequest
                        {
                            Id = d.Persona.Id,
                            Nombre = d.Persona.Nombre,
                            Apellido = d.Persona.Apellido,
                            Username = d.Persona.Username,
                            Contraseña = d.Persona.Contraseña,
                            Id_Direccion = d.Persona.Id_Direccion,
                            Tipo = d.Persona.Tipo,
                            Telefono = d.Persona.Telefono,
                            Email = d.Persona.Email,
                            Id_Persona = d.Id_Persona,
                            Dni = d.Dni,
                            Id_Rol = d.Id_Rol,
                            Fecha_Contratacion = d.Fecha_Contratacion,
                            Fecha_Despido = (DateTime)d.Fecha_Despido

                        }).ToList();
            }
            return list;
        }

        public List<EmpleadoRequest> Get(string var, int pag, int elements)
        {
            List<EmpleadoRequest> list = new List<EmpleadoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_INNER_JOIN_FILTER,var);
                list = (from d in db.Empleado.SqlQuery(query)
                        orderby d.Persona.Nombre
                        select new EmpleadoRequest
                        {
                            Id = d.Persona.Id,
                            Nombre = d.Persona.Nombre,
                            Apellido = d.Persona.Apellido,
                            Username = d.Persona.Username,
                            Contraseña = d.Persona.Contraseña,
                            Id_Direccion = d.Persona.Id_Direccion,
                            Tipo = d.Persona.Tipo,
                            Telefono = d.Persona.Telefono,
                            Email = d.Persona.Email,
                            Id_Persona = d.Id_Persona,
                            Dni = d.Dni,
                            Id_Rol = d.Id_Rol,
                            Fecha_Contratacion = DateTime.Now,
                            Fecha_Despido = (DateTime)d.Fecha_Despido

                        }).Skip(pag).Take(elements).ToList();
            }
            return list;
        }

        public int Update(EmpleadoRequest Entity)
        {
            int id = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    Empleado _Entity =
                        db.Empleado.Find(Entity.Id);

                    if (_Entity != null)
                    {

                        _Entity.Id_Persona = Entity.Id_Persona;
                        _Entity.Dni = Entity.Dni;
                        _Entity.Id_Rol = Entity.Id_Rol;
                        _Entity.Fecha_Contratacion = Entity.Fecha_Contratacion;
                        _Entity.Fecha_Despido = Entity.Fecha_Despido;
                        db.SaveChanges();

                        id = _Entity.Id_Persona;
                    }

                }
            }
            catch (IOException)
            {

            }
            return id;
        }

        public EmpleadoRequest GetByDni( string dni)
        {
            EmpleadoRequest Entity;
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
               
                    string query = string.Format(SELECT_INNER_JOIN_WHERE_DNI, dni);
                    Entity = (from d in db.Empleado.SqlQuery(query)
                              select new EmpleadoRequest
                              {
                                  Id = d.Persona.Id,
                                  Nombre = d.Persona.Nombre,
                                  Apellido = d.Persona.Apellido,
                                  Username = d.Persona.Username,
                                  Contraseña = d.Persona.Contraseña,
                                  Id_Direccion = d.Persona.Id_Direccion,
                                  Tipo = d.Persona.Tipo,
                                  Telefono = d.Persona.Telefono,
                                  Email = d.Persona.Email,
                                  Id_Persona = d.Id_Persona,
                                  Dni = d.Dni,
                                  Id_Rol = d.Id_Rol,
                                  Fecha_Contratacion = d.Fecha_Contratacion,
                                  Fecha_Despido = (DateTime)d.Fecha_Despido

                              }).FirstOrDefault(null);
                
            

            }
            return Entity;
        }

        
     
        

        public EmpleadoRequest GetWhere(string filter)
        {
            EmpleadoRequest list = new EmpleadoRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_INNER_JOIN_FILTER, filter);
                list = (from d in db.Empleado.SqlQuery(query)
                        select new EmpleadoRequest
                        {
                            Id = d.Persona.Id,
                            Nombre = d.Persona.Nombre,
                            Apellido = d.Persona.Apellido,
                            Username = d.Persona.Username,
                            Contraseña = d.Persona.Contraseña,
                            Id_Direccion = d.Persona.Id_Direccion,
                            Tipo = d.Persona.Tipo,
                            Telefono = d.Persona.Telefono,
                            Email = d.Persona.Email,
                            Id_Persona = d.Id_Persona,
                            Dni = d.Dni,
                            Id_Rol = d.Id_Rol,
                            Fecha_Contratacion = d.Fecha_Contratacion,
                            Fecha_Despido = (DateTime)d.Fecha_Despido

                        }).FirstOrDefault();
            }
            return list;
        }
    }
}