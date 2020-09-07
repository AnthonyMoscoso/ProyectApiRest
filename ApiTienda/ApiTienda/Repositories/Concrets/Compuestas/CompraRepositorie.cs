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
    public class CompraRepositorie : ICompraRepositorie
    {
        private string SELECT = "SELECT * FROM COMPRA WHERE {0}";
        public int Count()
        {
            int size = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    size = db.Compra.Count();
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
                    string query = string.Format("select * from Compra {0}", filter);
                    var result = db.Compra.SqlQuery(query).Count();
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
                Compra Entity;
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    if ((Entity = db.Compra.Find(id)) != null)
                    {
                        db.Compra.Remove(Entity);
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

        public List<CompraRequest> Get()
        {
            List<CompraRequest> list = new List<CompraRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Compra
                        select new CompraRequest
                        {
                            Id = d.Id,
                            Id_Comprador=d.Id_Comprador,
                            Id_Vendedor=d.Id_Vendedor,
                            Fecha=d.Fecha, 
                            FormaPago=d.FormaPago,
                            Descuento=d.Descuento
                        }).ToList();
            }
            return list;
        }

        public List<CompraRequest> Get(int page, int elements)
        {
            List<CompraRequest> list = new List<CompraRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Compra
                        orderby d.Id
                        select new CompraRequest
                        {
                            Id = d.Id,
                            Id_Comprador = d.Id_Comprador,
                            Id_Vendedor = d.Id_Vendedor,
                            Fecha = d.Fecha,
                            FormaPago = d.FormaPago,
                            Descuento = d.Descuento
                        }).Skip(page).Take(elements).ToList();
            }
            return list;
        }

        public CompraRequest Get(int id)
        {
            Compra Entity;
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                Entity = db.Compra.Find(id);

                if (Entity != null)
                {
                    CompraRequest request = new CompraRequest
                    {
                        Id = Entity.Id,
                        Id_Comprador = Entity.Id_Comprador,
                        Id_Vendedor = Entity.Id_Vendedor,
                        Fecha = Entity.Fecha,
                        FormaPago = Entity.FormaPago,
                        Descuento = Entity.Descuento
                    };
                    return request;
                }
            }

            return null;
        }

        public List<CompraRequest> GetComprasByIdCliente(int id)
        {
            List<CompraRequest> list = new List<CompraRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                list = (from d in db.Compra
                        where d.Id_Comprador==id
                        orderby d.Id
                        select new CompraRequest
                        {

                            Id = d.Id,
                            Id_Comprador = d.Id_Comprador,
                            Id_Vendedor = d.Id_Vendedor,
                            Fecha = d.Fecha,
                            FormaPago = d.FormaPago,
                            Descuento = d.Descuento


                        }).ToList();
            }
            return list;
        }

        public List<CompraRequest> GetComprasByIdEmpleado(int id)
        {
            List<CompraRequest> list = new List<CompraRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                list = (from d in db.Compra
                        where d.Id_Vendedor == id
                        orderby d.Id
                        select new CompraRequest
                        {

                            Id = d.Id,
                            Id_Comprador = d.Id_Comprador,
                            Id_Vendedor = d.Id_Vendedor,
                            Fecha = d.Fecha,
                            FormaPago = d.FormaPago,
                            Descuento = d.Descuento


                        }).ToList();
            }
            return list;
        }

        public List<CompraRequest> GetComprasByIdComprador(int id, string fecha)
        {
            DateTime date = DateTime.Parse(fecha);
            List<CompraRequest> list = new List<CompraRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                list = (from d in db.Compra
                        where d.Fecha.Day == date.Day && d.Id_Comprador==id
                        orderby d.Id
                        select new CompraRequest
                        {

                            Id = d.Id,
                            Id_Comprador = d.Id_Comprador,
                            Id_Vendedor = d.Id_Vendedor,
                            Fecha = d.Fecha,
                            FormaPago = d.FormaPago,
                            Descuento = d.Descuento


                        }).ToList();
            }
            return list;
        }

        public int Post(CompraRequest Entity)
        {
            Compra _Entity;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    _Entity = new Compra
                    {
                        Id_Comprador = Entity.Id_Comprador,
                        Id_Vendedor = Entity.Id_Vendedor,
                        Fecha = DateTime.Now,
                        FormaPago = Entity.FormaPago,
                        Descuento = Entity.Descuento

                    };
                    db.Compra.Add(_Entity);
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

        public List<CompraRequest> GetByDate(string fecha)
        {
            DateTime date = DateTime.Parse(fecha);
            List<CompraRequest> list = new List<CompraRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                list = (from d in db.Compra
                        where d.Fecha.Day == date.Day
                        orderby d.Id
                        select new CompraRequest
                        {

                            Id = d.Id,
                            Id_Comprador = d.Id_Comprador,
                            Id_Vendedor = d.Id_Vendedor,
                            Fecha = d.Fecha,
                            FormaPago = d.FormaPago,
                            Descuento = d.Descuento


                        }).ToList();
            }
            return list;
        }

        public List<CompraRequest> GetByDate(string var, int pag, int elements)
        {
            DateTime date = DateTime.Parse(var);
            List<CompraRequest> list = new List<CompraRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                list = (from d in db.Compra
                        where d.Fecha.Day == date.Day
                        orderby d.Id
                        select new CompraRequest
                        {

                            Id = d.Id,
                            Id_Comprador = d.Id_Comprador,
                            Id_Vendedor = d.Id_Vendedor,
                            Fecha = d.Fecha,
                            FormaPago = d.FormaPago,
                            Descuento = d.Descuento


                        }).Skip(pag).Take(elements).ToList();
            }
            return list;
        }

        public int Update(CompraRequest Entity)
        {
            int id = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    Compra _Entity =
                        db.Compra.Find(Entity.Id);

                    if (_Entity != null)
                    {
                        _Entity.Id = Entity.Id;
                        _Entity.Id_Comprador = Entity.Id_Comprador;
                        _Entity.Id_Vendedor = Entity.Id_Vendedor;
                        _Entity.Fecha = Entity.Fecha;
                        _Entity.FormaPago = Entity.FormaPago;
                        _Entity.Descuento = Entity.Descuento;
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

        public List<CompraRequest> Get(string filter)
        {
            List<CompraRequest> list = new List<CompraRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT, filter);
                list = (from d in db.Compra.SqlQuery(query)
                        orderby d.Id
                        select new CompraRequest
                        {
                            Id = d.Id,
                            Id_Comprador = d.Id_Comprador,
                            Id_Vendedor = d.Id_Vendedor,
                            Fecha = d.Fecha,
                            FormaPago = d.FormaPago,
                            Descuento = d.Descuento
                        }).ToList();
            }
            return list;
        }

        public List<CompraRequest> Get(string filter, int pag, int elements)
        {
            List<CompraRequest> list = new List<CompraRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT,filter);
                list = (from d in db.Compra.SqlQuery(query)
                        orderby d.Id
                        select new CompraRequest
                        {
                            Id = d.Id,
                            Id_Comprador = d.Id_Comprador,
                            Id_Vendedor = d.Id_Vendedor,
                            Fecha = d.Fecha,
                            FormaPago = d.FormaPago,
                            Descuento = d.Descuento
                        }).Skip(pag).Take(elements).ToList();
            }
            return list;
        }

        public CompraRequest GetWhere(string filter)
        {
            CompraRequest i = new CompraRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                var query = string.Format(SELECT, filter);
                i = (from d in db.Compra.SqlQuery(query)
                     orderby d.Id
                     select new CompraRequest
                     {
                         Id = d.Id,
                         Id_Comprador = d.Id_Comprador,
                         Id_Vendedor = d.Id_Vendedor,
                         Fecha = d.Fecha,
                         FormaPago = d.FormaPago,
                         Descuento = d.Descuento
                     }).FirstOrDefault();
            }
            return i;
        }
    }
}