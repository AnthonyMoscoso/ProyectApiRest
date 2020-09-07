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
    public class ClienteRepositorie : IClienteRepositorie
    {

        private static string SELECT_INNER_JOIN = "select * from Cliente inner join Persona on Persona.Id = {0} ;";
        private static string SELECT_INNER_JOIN_FILTER = "select * from Cliente inner join Persona on Persona.Id=Cliente.Id_Persona where {0} ;";
        private static string SELECT_INNER_JOIN_DIRECCION_FILTER= "select * from Cliente inner join Persona on Persona.Id = Cliente.Id_Persona" +
            " where Persona.Id_Direccion in (select Id from Direccion where {0} );";
        public int Count()
        {
            int count = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    count = db.Cliente.Count();
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
                    string query = string.Format("select * from Cliente {0}", filter);
                    var result = db.Cliente.SqlQuery(query).Count();
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
                Cliente Entity;
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    if ((Entity = db.Cliente.Find(id)) != null)
                    {
                        db.Cliente.Remove(Entity);
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
        public List<ClienteRequest> Get()
        {
            List<ClienteRequest> list = new List<ClienteRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_INNER_JOIN, " Cliente.Id_Persona ");
                list = (from d in db.Cliente.SqlQuery(query)
                        select new ClienteRequest
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
                            Descuento = d.Descuento,
                            Fecha_Alta= (DateTime)d.Fecha_Alta,
                            Fecha_Baja= (DateTime)d.Fecha_Baja

                            

                        }).ToList();
            }
            return list;
        }

        public List<ClienteRequest> Get(int page, int elements)
        {
            List<ClienteRequest> list = new List<ClienteRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_INNER_JOIN, "Cliente.Id_Persona");
                list = (from d in db.Cliente.SqlQuery(query)
                        select new ClienteRequest
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
                            Descuento = d.Descuento,
                            Fecha_Alta = (DateTime)d.Fecha_Alta,
                            Fecha_Baja = (DateTime)d.Fecha_Baja

                        }).Skip(page).Take(elements).ToList();
            }
            return list;
        }

        public ClienteRequest Get(int id)
        {
            ClienteRequest Entity;
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_INNER_JOIN, id);
                Entity = (from d in db.Cliente.SqlQuery(query)
                          select new ClienteRequest
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
                              Descuento = d.Descuento,
                              Fecha_Alta = (DateTime)d.Fecha_Alta,
                              Fecha_Baja = (DateTime)d.Fecha_Baja

                          }).First();
            }
            return Entity;
        }

        public int Post(ClienteRequest Entity)
        {
            Cliente _Entity;

            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    _Entity = new Cliente
                    {
                        Id_Persona = Entity.Id_Persona,
                        Descuento = Entity.Descuento,
                        Fecha_Alta= Entity.Fecha_Alta,
                        Fecha_Baja= Entity.Fecha_Baja
                    };

                    db.Cliente.Add(_Entity);
                    db.SaveChanges();

                }
                return (_Entity.Id_Persona);
            }
            catch (DbUpdateException)
            {
                return 0;
            }
            catch (IOException)
            {
                return 0;
            }
        }

        public List<ClienteRequest> Get(string var)
        {
            List<ClienteRequest> list = new List<ClienteRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_INNER_JOIN_FILTER, var);
                list = (from d in db.Cliente.SqlQuery(query)
                        select new ClienteRequest
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
                            Descuento = d.Descuento,
                            Fecha_Alta = d.Fecha_Alta,
                            Fecha_Baja = (DateTime)d.Fecha_Baja

                        }).ToList();
            }
            return list;
        }

        public List<ClienteRequest> Get(string var, int pag, int elements)
        {
            List<ClienteRequest> list = new List<ClienteRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_INNER_JOIN_FILTER, var);
                list = (from d in db.Cliente.SqlQuery(query)
                        orderby d.Id_Persona
                        select new ClienteRequest
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
                            Descuento = d.Descuento,
                            Fecha_Alta = (DateTime)d.Fecha_Alta,
                            Fecha_Baja = (DateTime)d.Fecha_Baja

                        }).Skip(pag).Take(elements).ToList();
            }
            return list;
        }

        public List<ClienteRequest> SearchByDireccion(string filter, int page, int elements)
        {
            List<ClienteRequest> list = new List<ClienteRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_INNER_JOIN_DIRECCION_FILTER, filter);
                list = (from d in db.Cliente.SqlQuery(query)
                        orderby d.Id_Persona
                        select new ClienteRequest
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
                            Descuento = d.Descuento,
                            Fecha_Alta = (DateTime)d.Fecha_Alta,
                            Fecha_Baja = (DateTime)d.Fecha_Baja

                        }).Skip(page).Take(elements).ToList();
            }
            return list;
        }

        public List<ClienteRequest> SearchByDireccion(string filter)
        {
            List<ClienteRequest> list = new List<ClienteRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_INNER_JOIN_DIRECCION_FILTER, filter);
                list = (from d in db.Cliente.SqlQuery(query)
                        select new ClienteRequest
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
                            Descuento = d.Descuento,
                            Fecha_Alta = (DateTime)d.Fecha_Alta,
                            Fecha_Baja = (DateTime)d.Fecha_Baja

                        }).ToList();
            }
            return list;
        }

        public int Update(ClienteRequest Entity)
        {
            int id = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    Cliente _Entity =
                        db.Cliente.Find(Entity.Id);

                    if (_Entity != null)
                    {

                        _Entity.Id_Persona = Entity.Id_Persona;
                        _Entity.Descuento = Entity.Descuento;
                        _Entity.Fecha_Baja = Entity.Fecha_Baja;
                        _Entity.Fecha_Alta = Entity.Fecha_Alta;
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

        public ClienteRequest GetWhere(string filter)
        {
           ClienteRequest list = new ClienteRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_INNER_JOIN_FILTER, filter);
                list = (from d in db.Cliente.SqlQuery(query)
                        select new ClienteRequest
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
                            Descuento = d.Descuento,
                            Fecha_Alta = DateTime.Now,
                            Fecha_Baja = (DateTime)d.Fecha_Baja

                        }).FirstOrDefault();
            }
            return list;
        }
    }
}