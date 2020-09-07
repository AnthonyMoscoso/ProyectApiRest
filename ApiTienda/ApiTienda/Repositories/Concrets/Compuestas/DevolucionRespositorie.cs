using ApiTienda.Models;
using ApiTienda.Models.Request.Concret;
using ApiTienda.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Web;

namespace ApiTienda.Repositories.Concrets.Acciones
{
    public class DevolucionRespositorie : IDevolucionRepositorie
    {
        string SELECT = "SELECT * FROM DEVOLUCION  WHERE {0}";
        public int Count()
        {
            int size = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    size = db.Devolucion.Count();
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
                    string query = string.Format(SELECT, filter);
                    var result = db.Devolucion.SqlQuery(query).Count();
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
                Devolucion Entity;
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    if ((Entity = db.Devolucion.Find(id)) != null)
                    {
                        db.Devolucion.Remove(Entity);
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
        public List<DevolucionRequest> Get()
        {
            List<DevolucionRequest> list = new List<DevolucionRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Devolucion
                        select new DevolucionRequest
                        {
                            Id = d.Id,
                           
                            Fecha = d.Fecha,
                            Cantidad=d.Cantidad
                        }).ToList();
            }
            return list;
        }
        public List<DevolucionRequest> Get(int page, int elements)
        {
            List<DevolucionRequest> list = new List<DevolucionRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Devolucion
                        orderby d.Fecha
                        select new DevolucionRequest
                        {
                            Id = d.Id,
                            Id_LineaCompra=d.Id_LineaCompra,
                            Fecha = d.Fecha,
                            Cantidad = d.Cantidad
                        }).Skip(page).Take(elements).ToList();
            }
            return list;
        }
        public DevolucionRequest Get(int id)
        {
            Devolucion Entity;
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                Entity = db.Devolucion.Find(id);

                if (Entity != null)
                {
                    DevolucionRequest request = new DevolucionRequest
                    {
                        Id = Entity.Id,
                        Id_LineaCompra = Entity.Id_LineaCompra,
                        Fecha = Entity.Fecha,
                        Cantidad = Entity.Cantidad
                    };
                    return request;
                }
            }

            return null;
        }
        public int Post(DevolucionRequest Entity)
        {
            Devolucion _Entity;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    _Entity = new Devolucion
                    {
                        Id_LineaCompra = Entity.Id_LineaCompra,
                        Fecha = DateTime.Now,
                        Cantidad = Entity.Cantidad

                    };
                    db.Devolucion.Add(_Entity);
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
        public List<DevolucionRequest> GetByDate(string var)
        {
            DateTime date = DateTime.Parse(var);
            List<DevolucionRequest> list = new List<DevolucionRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                list = (from d in db.Devolucion
                        where d.Fecha.Day == date.Day
                        orderby d.Id
                        select new DevolucionRequest
                        {

                            Id = d.Id,
                            Id_LineaCompra = d.Id_LineaCompra,
                            Fecha = d.Fecha,
                            Cantidad = d.Cantidad


                        }).ToList();
            }
            return list;
        }
        public List<DevolucionRequest> GetByDate(string var, int pag, int elements)
        {
            DateTime date = DateTime.Parse(var);
            List<DevolucionRequest> list = new List<DevolucionRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                list = (from d in db.Devolucion
                        where d.Fecha.Day == date.Day
                        orderby d.Id
                        select new DevolucionRequest
                        {

                            Id = d.Id,
                            Id_LineaCompra = d.Id_LineaCompra,
                            Fecha = d.Fecha,
                            Cantidad = d.Cantidad


                        }).Skip(pag).Take(elements).ToList();
            }
            return list;
        }
        public int Update(DevolucionRequest Entity)
        {
            int id = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    Devolucion _Entity =
                        db.Devolucion.Find(Entity.Id);

                    if (_Entity != null)
                    {
                        _Entity.Id = Entity.Id;
                        _Entity.Id_LineaCompra = Entity.Id_LineaCompra;
                        _Entity.Fecha = Entity.Fecha;
                        _Entity.Cantidad = Entity.Cantidad;
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
        public List<DevolucionRequest> Get(string filter)
        {
            List<DevolucionRequest> list = new List<DevolucionRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT, filter);
                list = (from d in db.Devolucion.SqlQuery(query)
                        orderby d.Fecha
                        select new DevolucionRequest
                        {
                            Id = d.Id,
                            Id_LineaCompra = d.Id_LineaCompra,
                            Fecha = d.Fecha,
                            Cantidad = d.Cantidad
                        }).ToList();
            }
            return list;
        }
        public List<DevolucionRequest> Get(string filter, int pag, int elements)
        {
            List<DevolucionRequest> list = new List<DevolucionRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT,filter);
                list = (from d in db.Devolucion.SqlQuery(query)
                        orderby d.Fecha
                        select new DevolucionRequest
                        {
                            Id = d.Id,
                            Id_LineaCompra = d.Id_LineaCompra,
                            Fecha = d.Fecha,
                            Cantidad = d.Cantidad
                        }).Skip(pag).Take(elements).ToList();
            }
            return list;
        }

        public DevolucionRequest GetWhere(string filter)
        {
            DevolucionRequest list = new DevolucionRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT, filter);
                list = (from d in db.Devolucion.SqlQuery(query)
                        orderby d.Fecha
                        select new DevolucionRequest
                        {
                            Id = d.Id,
                            Id_LineaCompra = d.Id_LineaCompra,
                            Fecha = d.Fecha,
                            Cantidad = d.Cantidad
                        }).FirstOrDefault(null);
            }
            return list;
        }
    }
}