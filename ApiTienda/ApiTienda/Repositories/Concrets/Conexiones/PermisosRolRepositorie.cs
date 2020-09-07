using ApiTienda.Models;
using ApiTienda.Models.Request.Concret;
using ApiTienda.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Web;

namespace ApiTienda.Repositories.Concrets.Conexiones
{
    public class PermisosRolRepositorie : IPermisosRolRepositorie
    {
        private static string SELECT_FROM_WHERE = "select * from PermisosRol where {0}";
        public int Count()
        {
            int size = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    size = db.PermisosRol.Count();
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
                    string query = string.Format(SELECT_FROM_WHERE, filter);
                    var result = db.PermisosRol.SqlQuery(query).Count();
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
                PermisosRol Entity;
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    if ((Entity = db.PermisosRol.Find(id)) != null)
                    {
                        db.PermisosRol.Remove(Entity);
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
        public List<PermisosRolRequest> Get()
        {
            List<PermisosRolRequest> list = new List<PermisosRolRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.PermisosRol
                        select new PermisosRolRequest
                        {
                            Id = d.Id,
                            Id_Permiso=d.Id_Permiso,
                            Id_Rol=d.Id_Rol
                         
                        }).ToList();
            }
            return list;
        }
        public List<PermisosRolRequest> Get(int page, int elements)
        {
            List<PermisosRolRequest> list = new List<PermisosRolRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.PermisosRol
                        select new PermisosRolRequest
                        {
                            Id = d.Id,
                            Id_Permiso = d.Id_Permiso,
                            Id_Rol = d.Id_Rol

                        }).Skip(page).Skip(elements).ToList();
            }
            return list;
        }
        public PermisosRolRequest Get(int id)
        {
            PermisosRol Entity;
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                Entity = db.PermisosRol.Find(id);

                if (Entity != null)
                {
                    PermisosRolRequest request = new PermisosRolRequest
                    {
                        Id = Entity.Id,
                        Id_Permiso = Entity.Id_Permiso,
                        Id_Rol = Entity.Id_Rol
                    };
                    return request;
                }
            }

            return null;
        }
        public List<PermisosRolRequest> Get(string filter)
        {
            List<PermisosRolRequest> list = new List<PermisosRolRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT_FROM_WHERE,filter);
                list = (from d in db.PermisosRol.SqlQuery(query)
                        select new PermisosRolRequest
                        {
                            Id = d.Id,
                            Id_Permiso = d.Id_Permiso,
                            Id_Rol = d.Id_Rol

                        }).ToList();
            }
            return list;
        }
        public List<PermisosRolRequest> Get(string filter, int pag, int elements)
        {
            List<PermisosRolRequest> list = new List<PermisosRolRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                var query = string.Format(SELECT_FROM_WHERE, filter);
                list = (from d in db.PermisosRol.SqlQuery(query)
                        orderby d.Id
                        select new PermisosRolRequest
                        {
                            Id = d.Id,
                            Id_Permiso = d.Id_Permiso,
                            Id_Rol = d.Id_Rol

                        }).Skip(pag).Skip(elements).ToList();
            }
            return list;
        }

        public PermisosRolRequest GetWhere(string filter)
        {
            PermisosRolRequest list = new PermisosRolRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT_FROM_WHERE, filter);
                list = (from d in db.PermisosRol.SqlQuery(query)
                        select new PermisosRolRequest
                        {
                            Id = d.Id,
                            Id_Permiso = d.Id_Permiso,
                            Id_Rol = d.Id_Rol

                        }).FirstOrDefault();
            }
            return list;
        }

        public int Post(PermisosRolRequest Entity)
        {
            PermisosRol _Entity;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    _Entity = new PermisosRol
                    {
     
                        Id_Permiso = (int)Entity.Id_Permiso,
                        Id_Rol = (int)Entity.Id_Rol

                    };
                    db.PermisosRol.Add(_Entity);
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
        public int Update(PermisosRolRequest Entity)
        {
            int id = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    PermisosRol _Entity =
                        db.PermisosRol.Find(Entity.Id);

                    if (_Entity != null)
                    {
                        _Entity.Id = Entity.Id;
                        _Entity.Id_Permiso = (int)Entity.Id_Permiso;
                        _Entity.Id_Rol = (int)Entity.Id_Rol;
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