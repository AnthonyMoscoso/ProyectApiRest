using ApiTienda.Models;
using ApiTienda.Models.Request.Abstract;
using ApiTienda.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Web;

namespace ApiTienda.Repositories.Concrets
{
    public class PersonaRepositorie : IPersonaRepositorie
    {
        private string SELECT_FROM=("SELECT * FROM PERSONA WHERE {0}");
        public int Count()
        {
            int count = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    count = db.Persona.Count();
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
                    string query = string.Format("select * from Persona {0}", filter);
                    var result = db.Persona.SqlQuery(query).Count();
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
                Persona Entity;
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    if ((Entity = db.Persona.Find(id)) != null)
                    {
                        db.Persona.Remove(Entity);
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

        public bool ExistEmail(string email)
        {
            PersonaRequest _Entity = new PersonaRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                try
                {
                    _Entity = (from d in db.Persona
                               where d.Email == email
                               select new PersonaRequest()
                               ).FirstOrDefault();
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

        public bool ExistEmail(int id, string email)
        {
            PersonaRequest _Entity = new PersonaRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                try
                {
                    _Entity = (from d in db.Persona
                               where d.Email == email && d.Id==id
                               select new PersonaRequest()
                               {
                                   Id=d.Id
                               }).FirstOrDefault();
                    if (_Entity != null )
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

        public bool ExistPhone(string number)
        {
            PersonaRequest _Entity = new PersonaRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                try
                {
                    _Entity = (from d in db.Persona
                               where d.Telefono == number
                               select new PersonaRequest()
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

        public bool ExistPhone(int id, string number)
        {
            PersonaRequest _Entity = new PersonaRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                try
                {
                    _Entity = (from d in db.Persona
                               where d.Telefono == number && d.Id==id
                               select new PersonaRequest()
                               {
                               }
                               ).FirstOrDefault();
                    if (_Entity != null )
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

        public bool ExistUsername(string name)
        {
            PersonaRequest _Entity = new PersonaRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                try
                {
                    _Entity = (from d in db.Persona
                               where d.Username == name
                               select new PersonaRequest()
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

        public bool ExistUsername(int id, string name)
        {
            PersonaRequest _Entity = new PersonaRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                try
                {
                    _Entity = (from d in db.Persona
                               where d.Username == name && d.Id==id
                               select new PersonaRequest()
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

        public List<PersonaRequest> Get()
        {
            List<PersonaRequest> list = new List<PersonaRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Persona
                        select new PersonaRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre,
                            Apellido = d.Apellido,
                            Username = d.Username,
                            Contraseña = d.Contraseña,
                            Id_Direccion = d.Id_Direccion,
                            Tipo = d.Tipo,
                            Telefono = d.Telefono,
                            Email = d.Email

                        }).ToList();
            }
            return list;
        }

        public List<PersonaRequest> Get(int page, int elements)
        {
            List<PersonaRequest> list = new List<PersonaRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Persona
                        orderby d.Nombre
                        select new PersonaRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre,
                            Apellido = d.Apellido,
                            Username = d.Username,
                            Contraseña = d.Contraseña,
                            Id_Direccion = d.Id_Direccion,
                            Tipo = d.Tipo,
                            Telefono = d.Telefono,
                            Email = d.Email

                        }).Skip(page).Take(elements).ToList();
            }
            return list;
        }

        public PersonaRequest Get(int id)
        {
            Persona Entity;
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                Entity = db.Persona.Find(id);

                if (Entity != null)
                {
                    PersonaRequest request = new PersonaRequest
                    {
                        Id = Entity.Id,
                        Nombre = Entity.Nombre,
                        Apellido = Entity.Apellido,
                        Username = Entity.Username,
                        Contraseña = Entity.Contraseña,
                        Id_Direccion = Entity.Id_Direccion,
                        Tipo = Entity.Tipo,
                        Telefono = Entity.Telefono,
                        Email = Entity.Email
                    };
                    return request;
                }
            }

            return null;
        }

        public List<PersonaRequest> Get(string filter)
        {
            List<PersonaRequest> list = new List<PersonaRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT_FROM,filter);
                list = (from d in db.Persona.SqlQuery(query)
                        orderby d.Nombre
                        select new PersonaRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre,
                            Apellido = d.Apellido,
                            Username = d.Username,
                            Contraseña = d.Contraseña,
                            Id_Direccion = d.Id_Direccion,
                            Tipo = d.Tipo,
                            Telefono = d.Telefono,
                            Email = d.Email

                        }).ToList();
            }
            return list;
        }

        public List<PersonaRequest> Get(string filter, int pag, int elements)
        {
            List<PersonaRequest> list = new List<PersonaRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT_FROM, filter);
                list = (from d in db.Persona.SqlQuery(query)
                        orderby d.Nombre
                        select new PersonaRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre,
                            Apellido = d.Apellido,
                            Username = d.Username,
                            Contraseña = d.Contraseña,
                            Id_Direccion = d.Id_Direccion,
                            Tipo = d.Tipo,
                            Telefono = d.Telefono,
                            Email = d.Email

                        }).Skip(pag).Take(elements).ToList();
            }
            return list;
        }

        public PersonaRequest GetWhere(string filter)
        {
            PersonaRequest list = new PersonaRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT_FROM, filter);
                list = (from d in db.Persona.SqlQuery(query)
                        orderby d.Nombre
                        select new PersonaRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre,
                            Apellido = d.Apellido,
                            Username = d.Username,
                            Contraseña = d.Contraseña,
                            Id_Direccion = d.Id_Direccion,
                            Tipo = d.Tipo,
                            Telefono = d.Telefono,
                            Email = d.Email

                        }).FirstOrDefault();
            }
            return list;
        }

        public PersonaRequest Login(string Username, string PassWord)
        {
            PersonaRequest _Entity = new PersonaRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                _Entity = (from d in db.Persona
                           where d.Username == Username && d.Contraseña==PassWord
                           select new PersonaRequest
                           {
                               Id = d.Id,
                               Nombre=d.Nombre,
                               Apellido=d.Apellido,
                               Username=d.Username,
                               Contraseña=d.Contraseña,
                               Id_Direccion=d.Id_Direccion,
                               Tipo=d.Tipo,
                               Telefono=d.Telefono,
                               Email=d.Email

                           }).First();
                if (_Entity != null)
                {
                    return _Entity;
                }
                return null;
            }
        }

        public int Post(PersonaRequest Entity)
        {
            Persona _Entity;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    _Entity = new Persona
                    {
                        Nombre = Entity.Nombre,
                        Apellido = Entity.Apellido,
                        Username = Entity.Username,
                        Contraseña = Entity.Contraseña,
                        Id_Direccion = Entity.Id_Direccion,
                        Tipo = Entity.Tipo,
                        Telefono = Entity.Telefono,
                        Email = Entity.Email
                    };
                    db.Persona.Add(_Entity);
                    db.SaveChanges();
                }
                return (_Entity.Id);
            }
         
            catch (IOException)
            {
                return 0;
            }
        }

       
        public int Update(PersonaRequest Entity)
        {
            int id = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    Persona _Entity =
                        db.Persona.Find(Entity.Id);

                    if (_Entity != null)
                    {
                        _Entity.Nombre = Entity.Nombre;
                        _Entity.Apellido = Entity.Apellido;
                        _Entity.Username = Entity.Username;
                        _Entity.Contraseña = Entity.Contraseña;
                        _Entity.Id_Direccion = Entity.Id_Direccion;
                        _Entity.Tipo = Entity.Tipo;
                        _Entity.Telefono = Entity.Telefono;
                        _Entity.Email = Entity.Email;


                        db.SaveChanges();

                        id = _Entity.Id;
                    }
                    return id;
                }
            }
            catch (IOException)
            {
                return id;
            }
        }
    }
}