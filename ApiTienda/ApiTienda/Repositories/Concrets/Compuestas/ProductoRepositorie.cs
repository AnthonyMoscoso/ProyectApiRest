using ApiTienda.Models;
using ApiTienda.Models.Request.Abstract;
using ApiTienda.Repositories.Abstracts;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Web;

namespace ApiTienda.Repositories.Concrets
{
    public class ProductoRepositorie : IProductoRepositorie
    {
        private static string SELECT_FROM = "SELECT * FROM PRODUCTO WHERE {0}";
        public int Count()
        {
            int size = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    size = db.Producto.Count();
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
                    string query = string.Format(SELECT_FROM, filter);
                    var result = db.Producto.SqlQuery(query).Count();
                    size = result;
                }
            }
            catch (IOException)
            {
                return 0;
            }
            return size;
        }

        public string Delete(int Id)
        {
            try
            {
                Producto Entity;
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    if ((Entity = db.Producto.Find(Id)) != null)
                    {
                        db.Producto.Remove(Entity);
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

        public List<ProductoRequest> Get()
        {
            List<ProductoRequest> list = new List<ProductoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Producto
                        select new ProductoRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre,
                            Imagen=d.Imagen,
                            Id_Categoria=d.Id_Categoria,
                            PrecioCompra=d.PrecioCompra,
                            PrecioVenta=d.PrecioVenta,
                            Descuento=d.Descuento,
                            FechaCreacion=d.FechaCreacion,
                            Estado=d.Estado,
                            CantidadInventario=d.CantidadInventario
                           

                        }).ToList();
            }
            return list;
        }

        public List<ProductoRequest> Get(int Page, int Elements)
        {
            List<ProductoRequest> list = new List<ProductoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                list = (from d in db.Producto
                        orderby d.Id
                        select new ProductoRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre,
                            Imagen = d.Imagen,
                            Id_Categoria = d.Id_Categoria,
                            PrecioCompra = d.PrecioCompra,
                            PrecioVenta = d.PrecioVenta,
                            Descuento = d.Descuento,
                            FechaCreacion = d.FechaCreacion,
                            Estado = d.Estado,
                            CantidadInventario = d.CantidadInventario
                        }).Skip(Page).Take(Elements).ToList();
            }
            return list;
        }

        public ProductoRequest Get(int id)
        {
            Producto Entity;
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                Entity = db.Producto.Find(id);

                if (Entity != null)
                {
                    ProductoRequest request = new ProductoRequest
                    {
                        Id = Entity.Id,
                        Nombre = Entity.Nombre,
                        Imagen = Entity.Imagen,
                        Id_Categoria = Entity.Id_Categoria,
                        PrecioCompra = Entity.PrecioCompra,
                        PrecioVenta = Entity.PrecioVenta,
                        Descuento = Entity.Descuento,
                        FechaCreacion = Entity.FechaCreacion,
                        Estado = Entity.Estado,
                        CantidadInventario = Entity.CantidadInventario
                    };
                    return request;
                }
            }
            return null;
        }

        public int Post(ProductoRequest Entity)
        {
            Producto _Entity;
            
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    _Entity = new Producto
                    {
                        Nombre = Entity.Nombre,
                        Imagen = Entity.Imagen,
                        Id_Categoria = Entity.Id_Categoria,
                        PrecioCompra = Entity.PrecioCompra,
                        PrecioVenta = Entity.PrecioVenta,
                        Descuento = Entity.Descuento,
                        FechaCreacion = DateTime.Now,
                        Estado = Entity.Estado,
                        CantidadInventario = Entity.CantidadInventario
                    };
                    db.Producto.Add(_Entity);
                    db.SaveChanges();
                }
                return (_Entity.Id);
            
       
        }

        public List<ProductoRequest> Get(string name)
        {
            List<ProductoRequest> list = new List<ProductoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_FROM, name);
                list = (from d in db.Producto.SqlQuery(query)
                        select new ProductoRequest
                        {

                            Id = d.Id,
                            Nombre = d.Nombre,
                            Imagen = d.Imagen,
                            Id_Categoria = d.Id_Categoria,
                            PrecioCompra = d.PrecioCompra,
                            PrecioVenta = d.PrecioVenta,
                            Descuento = d.Descuento,
                            FechaCreacion = d.FechaCreacion,
                            Estado = d.Estado,
                            CantidadInventario = d.CantidadInventario


                        }).ToList();
            }
            return list;
        }

        public List<ProductoRequest> Get(string name, int pag, int elements)
        {
            List<ProductoRequest> list = new List<ProductoRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_FROM,name);
                list = (from d in db.Producto.SqlQuery(query)
                        orderby d.Nombre
                        select new ProductoRequest
                        {

                            Id = d.Id,
                            Nombre = d.Nombre,
                            Imagen = d.Imagen,
                            Id_Categoria = d.Id_Categoria,
                            PrecioCompra = d.PrecioCompra,
                            PrecioVenta = d.PrecioVenta,
                            Descuento = d.Descuento,
                            FechaCreacion = d.FechaCreacion,
                            Estado = d.Estado,
                            CantidadInventario = d.CantidadInventario


                        }).Skip(pag).Take(elements).ToList();
            }
            return list;
        }

        public int Update(ProductoRequest Entity)
        {
            int id = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    Producto _Entity =
                        db.Producto.Find(Entity.Id);

                    if (_Entity != null)
                    {
                        _Entity.Id = Entity.Id;
                        _Entity.Nombre = Entity.Nombre;
                        _Entity.Imagen = Entity.Imagen;
                        _Entity.Id_Categoria = Entity.Id_Categoria;
                        _Entity.PrecioCompra = Entity.PrecioCompra;
                        _Entity.PrecioVenta = Entity.PrecioVenta;
                        _Entity.Descuento = Entity.Descuento;
                        _Entity.FechaCreacion = Entity.FechaCreacion;
                        _Entity.Estado = Entity.Estado;
                        _Entity.CantidadInventario = Entity.CantidadInventario;
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

        public ProductoRequest GetWhere(string filter)
        {
            ProductoRequest list = new ProductoRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_FROM, filter);
                list = (from d in db.Producto.SqlQuery(query)
                        select new ProductoRequest
                        {

                            Id = d.Id,
                            Nombre = d.Nombre,
                            Imagen = d.Imagen,
                            Id_Categoria = d.Id_Categoria,
                            PrecioCompra = d.PrecioCompra,
                            PrecioVenta = d.PrecioVenta,
                            Descuento = d.Descuento,
                            FechaCreacion = d.FechaCreacion,
                            Estado = d.Estado,
                            CantidadInventario = d.CantidadInventario


                        }).FirstOrDefault();
            }
            return list;
        }

        public int CantidadEnInventario(int id)
        {
            int Cantidad = 0;
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format("Select * from Producto where Id={0} ;", id);
                Cantidad = (from d in db.Producto.SqlQuery(query)
                            select d.CantidadInventario).FirstOrDefault();
            }
                return Cantidad;
        }
    }
}