using ApiTienda.Models;
using ApiTienda.Models.Request.Concret;
using ApiTienda.Repositories.Abstracts;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Web;

namespace ApiTienda.Repositories.Concrets.Conexiones
{
    public class LineaPedidoRepositorie : ILineaPedidoRepositorie
    {
        private static string SELECT_FROM_WHERE = "SELECT * FROM LINEAPEDIDO WHERE {0}";
        public int Count()
        {
            int size = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    size = db.LineaPedido.Count();
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
                    var result = db.LineaPedido.SqlQuery(query).Count();
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
                LineaPedido Entity;
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    if ((Entity = db.LineaPedido.Find(id)) != null)
                    {
                        db.LineaPedido.Remove(Entity);
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
        public List<LineaPedidoRequest> Get()
        {
            List<LineaPedidoRequest> list = new List<LineaPedidoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.LineaPedido
                        select new LineaPedidoRequest
                        {
                            Id = d.Id,
                            Id_Pedido = d.Id_Pedido,
                            Id_Producto = d.Id_Producto,
                            Cantidad = d.Cantidad,
                            Precio = d.Precio
                        }).ToList();
            }
            return list;
        }
        public List<LineaPedidoRequest> Get(int page, int elements)
        {
            List<LineaPedidoRequest> list = new List<LineaPedidoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.LineaPedido
                        orderby d.Id_Pedido
                        select new LineaPedidoRequest
                        {
                            Id = d.Id,
                            Id_Pedido = d.Id_Pedido,
                            Id_Producto = d.Id_Producto,
                            Cantidad = d.Cantidad,
                            Precio = d.Precio
                        }).Skip(page).Take(elements).ToList();
            }
            return list;
        }
        public LineaPedidoRequest Get(int id)
        {
            LineaPedido Entity;
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                Entity = db.LineaPedido.Find(id);

                if (Entity != null)
                {
                    LineaPedidoRequest request = new LineaPedidoRequest
                    {
                        Id = Entity.Id,
                        Id_Pedido = Entity.Id_Pedido,
                        Id_Producto = Entity.Id_Producto,
                        Cantidad = Entity.Cantidad,
                        Precio = Entity.Precio
                    };
                    return request;
                }
            }

            return null;
        }
        public int Post(LineaPedidoRequest Entity)
        {
            LineaPedido _Entity;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    _Entity = new LineaPedido
                    {
                        Id_Pedido = Entity.Id_Pedido,
                        Id_Producto = Entity.Id_Producto,
                        Cantidad = Entity.Cantidad,
                        Precio = Entity.Precio

                    };
                    db.LineaPedido.Add(_Entity);
                    db.SaveChanges();
                }
                return (_Entity.Id_Pedido);
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
        public List<LineaPedidoRequest> Get(string var)
        {
            List<LineaPedidoRequest> list = new List<LineaPedidoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_FROM_WHERE,var);
                list = (from d in db.LineaPedido.SqlQuery(query)
                        orderby d.Id_Pedido
                        select new LineaPedidoRequest
                        {
                            Id = d.Id,
                            Id_Pedido = d.Id_Pedido,
                            Id_Producto = d.Id_Producto,
                            Cantidad = d.Cantidad,
                            Precio = d.Precio
                        }).ToList();
            }
            return list;
        }
        public List<LineaPedidoRequest> Get(string var, int pag, int elements)
        {
            List<LineaPedidoRequest> list = new List<LineaPedidoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_FROM_WHERE, var);
                list = (from d in db.LineaPedido.SqlQuery(query)
                        orderby d.Id_Pedido
                        select new LineaPedidoRequest
                        {
                            Id = d.Id,
                            Id_Pedido = d.Id_Pedido,
                            Id_Producto = d.Id_Producto,
                            Cantidad = d.Cantidad,
                            Precio = d.Precio
                        }).Skip(pag).Take(elements).ToList();
            }
            return list;
        }
        public int Update(LineaPedidoRequest Entity)
        {
            return 0;
        }

        public LineaPedidoRequest GetWhere(string filter)
        { 
            LineaPedidoRequest list = new LineaPedidoRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_FROM_WHERE, filter);
                list = (from d in db.LineaPedido.SqlQuery(query)
                        orderby d.Id_Pedido
                        select new LineaPedidoRequest
                        {
                            Id = d.Id,
                            Id_Pedido = d.Id_Pedido,
                            Id_Producto = d.Id_Producto,
                            Cantidad = d.Cantidad,
                            Precio = d.Precio
                        }).FirstOrDefault();
            }
            return list;
        }
    }
}