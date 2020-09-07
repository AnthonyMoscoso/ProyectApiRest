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
    public class PedidoRepositorie : IPedidoRepositorie
    {
        private string SELECT = "SELECT * FROM PEDIDO WHERE {0}";
        public int Count()
        {
            int size = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    size = db.Reserva.Count();
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
                    var result = db.Pedido.SqlQuery(query).Count();
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
                Pedido Entity;
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    if ((Entity = db.Pedido.Find(id)) != null)
                    {
                        db.Pedido.Remove(Entity);
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
        public List<PedidoRequest> Get()
        {
            List<PedidoRequest> list = new List<PedidoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Pedido
                        select new PedidoRequest
                        {
                            Id = d.Id,
                            Id_Empleado =d.Id_Empleado,
                            Fecha=d.Fecha
                        }).ToList();
            }
            return list;
        }
        public List<PedidoRequest> Get(int page, int elements)
        {
            List<PedidoRequest> list = new List<PedidoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Pedido
                        select new PedidoRequest
                        {
                            Id = d.Id,
                            Id_Empleado = d.Id_Empleado,
                            Fecha = d.Fecha
                        }).Skip(page).Take(elements).ToList();
            }
            return list;
        }
        public PedidoRequest Get(int id)
        {
            Pedido Entity;
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                Entity = db.Pedido.Find(id);

                if (Entity != null)
                {
                    PedidoRequest request = new PedidoRequest
                    {
                        Id = Entity.Id,
                        Id_Empleado = Entity.Id_Empleado,
                        Fecha = Entity.Fecha
                    };
                    return request;
                }
            }

            return null;
        }
        public int Post(PedidoRequest Entity)
        {
            Pedido _Entity;

            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    _Entity = new Pedido
                    {
                        Id_Empleado = Entity.Id_Empleado,
                        Fecha = DateTime.Now
                    };

                    db.Pedido.Add(_Entity);
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
        public List<PedidoRequest> GetByDate(string var)
        {
            DateTime date = DateTime.Parse(var);
            List<PedidoRequest> list = new List<PedidoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                list = (from d in db.Pedido
                        where d.Fecha.Day == date.Day
                        orderby d.Id
                        select new PedidoRequest
                        {

                            Id = d.Id,
                            Id_Empleado = d.Id_Empleado,
                            Fecha = d.Fecha


                        }).ToList();
            }
            return list;
        }
        public List<PedidoRequest> GetByDate(string var, int pag, int elements)
        {
            DateTime date = DateTime.Parse(var);
            List<PedidoRequest> list = new List<PedidoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                list = (from d in db.Pedido
                        where d.Fecha.Day == date.Day
                        orderby d.Id
                        select new PedidoRequest
                        {

                            Id = d.Id,
                            Id_Empleado = d.Id_Empleado,
                            Fecha =d.Fecha


                        }).Skip(pag).Take(elements).ToList();
            }
            return list;
        }
        public int Update(PedidoRequest Entity)
        {
            int id = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    Pedido _Entity =
                        db.Pedido.Find(Entity.Id);

                    if (_Entity != null)
                    {
                        _Entity.Id = Entity.Id;
                        _Entity.Id_Empleado = Entity.Id_Empleado;
                        _Entity.Fecha = Entity.Fecha;
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
        public List<PedidoRequest> Get(string filter)
        {
            List<PedidoRequest> list = new List<PedidoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT,filter);
                list = (from d in db.Pedido.SqlQuery(query)
                        select new PedidoRequest
                        {
                            Id = d.Id,
                            Id_Empleado = d.Id_Empleado,
                            Fecha = d.Fecha
                        }).ToList();
            }
            return list;
        }
        public List<PedidoRequest> Get(string filter, int pag, int elements)
        {
            List<PedidoRequest> list = new List<PedidoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT, filter);
                list = (from d in db.Pedido.SqlQuery(query)
                        select new PedidoRequest
                        {
                            Id = d.Id,
                            Id_Empleado = d.Id_Empleado,
                            Fecha = d.Fecha
                        }).Skip(pag).Take(elements).ToList();
            }
            return list;
        }

        public PedidoRequest GetWhere(string filter)
        {
            PedidoRequest list = new PedidoRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT, filter);
                list = (from d in db.Pedido.SqlQuery(query)
                        select new PedidoRequest
                        {
                            Id = d.Id,
                            Id_Empleado = d.Id_Empleado,
                            Fecha = d.Fecha
                        }).FirstOrDefault(null);
            }
            return list;
        }
    }
}