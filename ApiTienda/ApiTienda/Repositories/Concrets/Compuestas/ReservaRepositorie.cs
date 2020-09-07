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
    public class ReservaRepositorie : IReservaRepositorie
    {

        private static string SELECT_FROM_RESERVA = "select * from Reserva where {0}";
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
                    string query = string.Format("select * from Reserva {0}", filter);
                    var result = db.Reserva.SqlQuery(query).Count();
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
                Reserva Entity;
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    if ((Entity = db.Reserva.Find(id)) != null)
                    {
                        db.Reserva.Remove(Entity);
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
        public List<ReservaRequest> Get()
        {
            List<ReservaRequest> list = new List<ReservaRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Reserva
                        select new ReservaRequest
                        {
                            Id = d.Id,
                            Id_Persona=d.Id_Persona,
                            Id_Producto=d.Id_Producto,
                            Cantidad=d.Cantidad,
                            Precio=d.Precio,
                            FechaFin=d.FechaFin,
                            FechaInicio=d.FechaInicio,
                            Estado=d.Estado
                        }).ToList();
            }
            return list;
        }
        public List<ReservaRequest> Get(int page, int elements)
        {
            List<ReservaRequest> list = new List<ReservaRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Reserva
                        select new ReservaRequest
                        {
                            Id = d.Id,
                            Id_Persona = d.Id_Persona,
                            Id_Producto = d.Id_Producto,
                            Cantidad = d.Cantidad,
                            Precio = d.Precio,
                            FechaFin = d.FechaFin,
                            FechaInicio = d.FechaInicio,
                            Estado = d.Estado
                        }).Skip(page).Take(elements).ToList();
            }
            return list;
        }
        public ReservaRequest Get(int id)
        {
            Reserva Entity;
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                Entity = db.Reserva.Find(id);

                if (Entity != null)
                {
                    ReservaRequest request = new ReservaRequest
                    {
                        Id = Entity.Id,
                        Id_Persona = Entity.Id_Persona,
                        Id_Producto = Entity.Id_Producto,
                        Cantidad = Entity.Cantidad,
                        Precio = Entity.Precio,
                        FechaFin = Entity.FechaFin,
                        FechaInicio = Entity.FechaInicio,
                        Estado = Entity.Estado
                    };
                    return request;
                }
            }

            return null;
        }
        public List<ReservaRequest> GetByIdClient(int id)
        {

            List<ReservaRequest> list = new List<ReservaRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Reserva
                        where d.Id_Persona==id
                        select new ReservaRequest
                        {
                            Id = d.Id,
                            Id_Persona = d.Id_Persona,
                            Id_Producto = d.Id_Producto,
                            Cantidad = d.Cantidad,
                            Precio = d.Precio,
                            FechaFin = d.FechaFin,
                            FechaInicio = d.FechaInicio,
                            Estado = d.Estado
                        }).ToList();
            }
            return list;
        }
        public List<ReservaRequest> GetByIdClient(int id, int skip, int take)
        {
            List<ReservaRequest> list = new List<ReservaRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Reserva
                        where d.Id_Persona == id
                        orderby d.Id
                        select new ReservaRequest
                        {
                            Id = d.Id,
                            Id_Persona = d.Id_Persona,
                            Id_Producto = d.Id_Producto,
                            Cantidad = d.Cantidad,
                            Precio = d.Precio,
                            FechaFin = d.FechaFin,
                            FechaInicio = d.FechaInicio,
                            Estado = d.Estado
                        }).Skip(skip).Take(take).ToList();
            }
            return list;
        }
        public int Post(ReservaRequest Entity)
        {
            Reserva _Entity;

            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    _Entity = new Reserva
                    {
                        Id_Persona = Entity.Id_Persona,
                        Id_Producto = Entity.Id_Producto,
                        Cantidad = Entity.Cantidad,
                        Precio = Entity.Precio,
                        FechaFin = Entity.FechaFin,
                        FechaInicio = DateTime.Now,
                        Estado = Entity.Estado
                    };

                    db.Reserva.Add(_Entity);
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
        public List<ReservaRequest> Get(string var)
        {
  
            List<ReservaRequest> list = new List<ReservaRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_FROM_RESERVA,var);
                list = (from d in db.Reserva.SqlQuery(query)
    
                        select new ReservaRequest
                        {

                            Id = d.Id,
                            Id_Persona = d.Id_Persona,
                            Id_Producto = d.Id_Producto,
                            Cantidad = d.Cantidad,
                            Precio = d.Precio,
                            FechaFin = d.FechaFin,
                            FechaInicio = d.FechaInicio,
                            Estado = d.Estado


                        }).ToList();
            }
            return list;
        }
        public List<ReservaRequest> Get(string var, int pag, int elements)
        {
            List<ReservaRequest> list = new List<ReservaRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_FROM_RESERVA, var);
                list = (from d in db.Reserva.SqlQuery(query)
                        orderby d.Id
                        select new ReservaRequest
                        {

                            Id = d.Id,
                            Id_Persona = d.Id_Persona,
                            Id_Producto = d.Id_Producto,
                            Cantidad = d.Cantidad,
                            Precio = d.Precio,
                            FechaFin = d.FechaFin,
                            FechaInicio = d.FechaInicio,
                            Estado = d.Estado


                        }).Skip(pag).Take(elements).ToList();
            }
            return list;
        }
        public int Update(ReservaRequest Entity)
        {
            int id = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    Reserva _Entity =
                        db.Reserva.Find(Entity.Id);

                    if (_Entity != null)
                    {
                        _Entity.Id = Entity.Id;
                        _Entity.Id_Persona = Entity.Id_Persona;
                         _Entity.Id_Producto = Entity.Id_Producto;
                        _Entity.Cantidad = Entity.Cantidad;
                        _Entity.Precio = Entity.Precio;
                        _Entity.FechaFin = Entity.FechaFin;
                        _Entity.FechaInicio = Entity.FechaInicio;
                        _Entity.Estado = Entity.Estado;
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

        public ReservaRequest GetWhere(string filter)
        {

            ReservaRequest list = new ReservaRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_FROM_RESERVA, filter);
                list = (from d in db.Reserva.SqlQuery(query)

                        select new ReservaRequest
                        {

                            Id = d.Id,
                            Id_Persona = d.Id_Persona,
                            Id_Producto = d.Id_Producto,
                            Cantidad = d.Cantidad,
                            Precio = d.Precio,
                            FechaFin = d.FechaFin,
                            FechaInicio = d.FechaInicio,
                            Estado = d.Estado


                        }).FirstOrDefault();
            }
            return list;
        }
    }
}