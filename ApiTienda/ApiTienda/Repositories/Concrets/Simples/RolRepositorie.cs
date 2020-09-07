using ApiTienda.Models;
using ApiTienda.Models.Request.Concret;
using ApiTienda.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Web;

namespace ApiTienda.Repositories.Concrets.Simples
{
    public class RolRepositorie : IRolRepositorie
    {
        private string SELECT = "SELECT * FROM ROL WHERE {0}";
        public int Count()
        {
            int size = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    size = db.Rol.Count();
                }
            }
            catch (IOException)
            {
                return 0;
            }
            return size;
        }

        public int Count(string filter)
        {
            int size = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    string query = string.Format("select * from Rol {0}", filter);
                    var result = db.Rol.SqlQuery(query).Count();
                    size = result;
                }
            }
            catch (IOException)
            {
                return 0;
            }
            return size;
        }

        public string Delete(int id)
        {
            try
            {
                Rol Entity;
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    if ((Entity = db.Rol.Find(id)) != null)
                    {
                        db.Rol.Remove(Entity);
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

        public List<RolRequest> Get()
        {
            List<RolRequest> list = new List<RolRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Rol
                        select new RolRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre

                        }).ToList();
            }
            return list;
        }

        public List<RolRequest> Get(int page, int elements)
        {
            List<RolRequest> list = new List<RolRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Rol
                        orderby d.Id
                        select new RolRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre

                        }).Skip(page).Take(elements).ToList();
            }
            return list;
        }

        public RolRequest Get(int id)
        {
            Rol Entity;
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                Entity = db.Rol.Find(id);

                if (Entity != null)
                {
                    RolRequest request = new RolRequest
                    {
                        Id = Entity.Id,
                        Nombre = Entity.Nombre,
                    };
                    return request;
                }
            }
            return null;
        }

        public List<RolRequest> Get(string filter)
        {
            List<RolRequest> list = new List<RolRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT, filter);
                list = (from d in db.Rol.SqlQuery(query)
                        orderby d.Id
                        select new RolRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre

                        }).ToList();
            }
            return list;
        }

        public List<RolRequest> Get(string filter, int pag, int elements)
        {
            List<RolRequest> list = new List<RolRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT,filter);
                list = (from d in db.Rol.SqlQuery(query)
                        orderby d.Id
                        select new RolRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre

                        }).Skip(pag).Take(elements).ToList();
            }
            return list;
        }

        public RolRequest GetWhere(string filter)
        {
            RolRequest list = new RolRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT, filter);
                list = (from d in db.Rol.SqlQuery(query)
                        orderby d.Id
                        select new RolRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre

                        }).FirstOrDefault();
            }
            return list;
        }

        public int Post(RolRequest Entity)
        {
            Rol _Entity;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    _Entity = new Rol
                    {
         
                        Nombre = Entity.Nombre,
                
                    };
                    db.Rol.Add(_Entity);
                    db.SaveChanges();
                }
                return (_Entity.Id);
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

        public int Update(RolRequest Entity)
        {

            int id = 0;

            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    Rol _Entity =
                        db.Rol.Find(Entity.Id);

                    if (_Entity != null)
                    {
                        _Entity.Id = Entity.Id;
                        _Entity.Nombre = Entity.Nombre;
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