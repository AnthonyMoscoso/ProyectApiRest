using ApiTienda.Models;
using ApiTienda.Models.Request.Abstract;
using ApiTienda.Models.Request.Concret;
using ApiTienda.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace ApiTienda.Repositories.Concrets.Simples
{
    public class PermisoRepositorie : IPermisoRepositorie
    {
        private static string SELECT = "select * from Permiso where {0} ;";
        private static string SELECT_Permiso = " ID IN (select id from PermisosRol where Id_Rol ={0}) ";
        public int Count()
        {
            int size = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    size = db.Permiso.Count();
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
                    string query =string.Format( SELECT ,filter);
                    var result = db.Permiso.SqlQuery(query).Count();
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
                Permiso Entity;
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    if ((Entity = db.Permiso.Find(id)) != null)
                    {
                        db.Permiso.Remove(Entity);
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

        public List<PermisoRequest> Get()
        {
            List<PermisoRequest> list = new List<PermisoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Permiso
                        select new PermisoRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre

                        }).ToList();
            }
            return list;
        }

        public List<PermisoRequest> Get(int page, int elements)
        {
            List<PermisoRequest> list = new List<PermisoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Permiso
                        orderby d.Id
                        select new PermisoRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre

                        }).Skip(page).Take(elements).ToList();
            }
            return list;
        }

        public PermisoRequest Get(int id)
        {
            Permiso Entity;
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                Entity = db.Permiso.Find(id);

                if (Entity != null)
                {
                    PermisoRequest request = new PermisoRequest
                    {
                        Id = Entity.Id,
                        Nombre = Entity.Nombre,
                    };
                    return request;
                }
            }
            return null;
        }

        public List<PermisoRequest> Get(string filter)
        {
            List<PermisoRequest> list = new List<PermisoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT, filter);
                list = (from d in db.Permiso.SqlQuery(query)
                        orderby d.Id
                        select new PermisoRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre

                        }).ToList();
            }
            return list;
        }

        public List<PermisoRequest> Get(string filter, int pag, int elements)
        {
            List<PermisoRequest> list = new List<PermisoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT,filter);
                list = (from d in db.Permiso.SqlQuery(query)
                        orderby d.Id
                        select new PermisoRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre

                        }).Skip(pag).Take(elements).ToList();
            }
            return list;
        }

        public List<PermisoRequest> GetByRol(int id)
        {
            List<PermisoRequest> list = new List<PermisoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string format = string.Format(SELECT,SELECT_Permiso);
                string query = string.Format(format, id);
                list = (from d in db.Permiso.SqlQuery(query)
                        select new PermisoRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre

                        }).ToList();

            } 
            return list;
        }

        public PermisoRequest GetWhere(string filter)
        {
            PermisoRequest list = new PermisoRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT, filter);
                list = (from d in db.Permiso.SqlQuery(query)
                        orderby d.Id
                        select new PermisoRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre

                        }).FirstOrDefault();
            }
            return list;
        }

        public int Post(PermisoRequest Entity)
        {
            Permiso _Entity;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    _Entity = new Permiso
                    {
     
                        Nombre = Entity.Nombre,

                    };
                    db.Permiso.Add(_Entity);
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

        public int Update(PermisoRequest Entity)
        {
            int id = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    Permiso _Entity =
                        db.Permiso.Find(Entity.Id);

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