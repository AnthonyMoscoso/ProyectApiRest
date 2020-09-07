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
    public class LineaCompraRepositorie : ILineaCompraRepositorie
    {
        private static string SELECT_FROM_WHERE = "select * from LineaCompra where {0}";
        public int Count()
        {
            int size = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    size = db.LineaCompra.Count();
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
                    var result = db.LineaCompra.SqlQuery(query).Count();
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
                LineaCompra Entity;
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    if ((Entity = db.LineaCompra.Find(id)) != null)
                    {
                        db.LineaCompra.Remove(Entity);
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
        public List<LineaCompraRequest> Get()
        {
            List<LineaCompraRequest> list = new List<LineaCompraRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.LineaCompra
                        select new LineaCompraRequest
                        {
                             Id=d.Id,
                             Id_Compra=d.Id_Compra,
                             Id_Producto=d.Id_Producto,
                             Cantidad=d.Cantidad,
                             Descuento=d.Descuento,
                             Precio=d.Precio
                        }).ToList();
            }
            return list;
        }
        public List<LineaCompraRequest> Get(int page, int elements)
        {
            List<LineaCompraRequest> list = new List<LineaCompraRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.LineaCompra
                        orderby d.Id_Compra
                        select new LineaCompraRequest
                        {
                            Id = d.Id,
                            Id_Compra = d.Id_Compra,
                            Id_Producto = d.Id_Producto,
                            Cantidad = d.Cantidad,
                            Descuento = d.Descuento,
                            Precio = d.Precio
                        }).Skip(page).Take(elements).ToList();
            }
            return list;
        }
        public LineaCompraRequest Get(int id)
        {
            LineaCompra Entity;
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                Entity = db.LineaCompra.Find(id);

                if (Entity != null)
                {
                    LineaCompraRequest request = new LineaCompraRequest
                    {
                        Id = Entity.Id,
                        Id_Compra = Entity.Id_Compra,
                        Id_Producto = Entity.Id_Producto,
                        Cantidad = Entity.Cantidad,
                        Descuento = Entity.Descuento,
                        Precio = Entity.Precio
                    };
                    return request;
                }
            }

            return null;
        }
        public List<LineaCompraRequest> Get(string filter)
        {
            List<LineaCompraRequest> list = new List<LineaCompraRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT_FROM_WHERE, filter);
                list = (from d in db.LineaCompra.SqlQuery(query)
                        orderby d.Id_Compra
                        select new LineaCompraRequest
                        {
                            Id_Compra = d.Id_Compra,
                            Id_Producto = d.Id_Producto,
                            Cantidad = d.Cantidad,
                            Descuento = d.Descuento,
                            Precio = d.Precio
                        }).ToList();
            }
            return list;
        }
        public List<LineaCompraRequest> Get(string filter, int pag, int elements)
        {
            List<LineaCompraRequest> list = new List<LineaCompraRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT_FROM_WHERE,filter);
                list = (from d in db.LineaCompra.SqlQuery(query)
                        orderby d.Id_Compra
                        select new LineaCompraRequest
                        {
                            Id=d.Id,
                            Id_Compra = d.Id_Compra,
                            Id_Producto = d.Id_Producto,
                            Cantidad = d.Cantidad,
                            Descuento = d.Descuento,
                            Precio = d.Precio
                        }).Skip(pag).Take(elements).ToList();
            }
            return list;
        }
        public List<LineaCompraRequest> GetByIdCompra(int id)
        {
            List<LineaCompraRequest> list = new List<LineaCompraRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.LineaCompra
                        where d.Id_Compra==id
                        select new LineaCompraRequest
                        {
                            Id_Compra = d.Id_Compra,
                            Id_Producto = d.Id_Producto,
                            Cantidad = d.Cantidad,
                            Descuento = d.Descuento,
                            Precio = d.Precio
                        }).ToList();
            }
            return list;
        }

        public LineaCompraRequest GetWhere(string filter)
        {
            LineaCompraRequest list = new LineaCompraRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT_FROM_WHERE, filter);
                list = (from d in db.LineaCompra.SqlQuery(query)
                        orderby d.Id_Compra
                        select new LineaCompraRequest
                        {
                            Id_Compra = d.Id_Compra,
                            Id_Producto = d.Id_Producto,
                            Cantidad = d.Cantidad,
                            Descuento = d.Descuento,
                            Precio = d.Precio
                        }).FirstOrDefault();
            }
            return list;
        }

        public int Post(LineaCompraRequest Entity)
        {
            LineaCompra _Entity;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    _Entity = new LineaCompra
                    {
                        Id_Compra = Entity.Id_Compra,
                        Id_Producto = Entity.Id_Producto,
                        Cantidad = Entity.Cantidad,
                        Descuento = Entity.Descuento,
                        Precio = Entity.Precio

                    };
                    db.LineaCompra.Add(_Entity);
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
        public int Update(LineaCompraRequest Entity)
        {
            int id = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    LineaCompra _Entity =
                        db.LineaCompra.Find(Entity.Id_Compra);

                    if (_Entity != null)
                    {
                        _Entity.Id_Compra = Entity.Id_Compra;
                        _Entity.Id_Producto = Entity.Id_Producto;
                        _Entity.Cantidad = Entity.Cantidad;
                        _Entity.Descuento = Entity.Descuento;
                        _Entity.Precio = Entity.Precio;
                        db.SaveChanges();

                        id = _Entity.Id_Compra;
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