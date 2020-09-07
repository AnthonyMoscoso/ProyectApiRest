using ApiTienda.Models;
using ApiTienda.Models.Request.Concret;
using ApiTienda.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Web;

namespace ApiTienda.Repositories.Concrets
{
    public class DireccionRepositorie : IDireccionRepositorie
    {
        private static string SELECT_FROM="SELECT * FROM DIRECCION WHERE {0}";
        public string Delete(int id)
        {
            try
            {
                Direccion Entity;
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    if ((Entity = db.Direccion.Find(id)) != null)
                    {
                        db.Direccion.Remove(Entity);
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
        public List<DireccionRequest> Get()
        {
            List<DireccionRequest> list = new List<DireccionRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Direccion
                        select new DireccionRequest
                        {
                            Id = d.Id,
                            Calle=d.Calle,
                            CodigoPostal=d.CodigoPostal,
                            Pais =d.Pais,
                            Ciudad=d.Ciudad
                        }).ToList();
            }
            return list;
        }
        public List<DireccionRequest> Get(int page, int elements)
        {
            List<DireccionRequest> list = new List<DireccionRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {


                list = (from d in db.Direccion
                        orderby d.Id
                        select new DireccionRequest
                        {
                            Id = d.Id,
                            Calle = d.Calle,
                            CodigoPostal = d.CodigoPostal,
                            Pais = d.Pais,
                            Ciudad = d.Ciudad


                        }).Skip(page).Take(elements).ToList();
            }
            return list;
        }
        public DireccionRequest Get(int id)
        {
            Direccion Entity;
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                Entity = db.Direccion.Find(id);

                if (Entity != null)
                {
                    DireccionRequest request = new DireccionRequest
                    {
                        Id = Entity.Id,
                        Calle = Entity.Calle,
                        CodigoPostal = Entity.CodigoPostal,
                        Pais = Entity.Pais,
                         Ciudad = Entity.Ciudad
                    };
                    return request;
                }
            }

            return null;
        }
        public int Post(DireccionRequest Entity)
        {
            Direccion _Entity;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    _Entity = new Direccion
                    {
                        Calle = Entity.Calle,
                        CodigoPostal = Entity.CodigoPostal,
                        Ciudad = Entity.Ciudad,
                        Pais = Entity.Pais

                    };
                    db.Direccion.Add(_Entity);
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
        public int Update(DireccionRequest Entity)
        {
            int id = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    Direccion _Entity =
                        db.Direccion.Find(Entity.Id);

                    if (_Entity != null)
                    {
                        _Entity.Id = Entity.Id;
                        _Entity.Calle = Entity.Calle;
                        _Entity.CodigoPostal = Entity.CodigoPostal;
                        _Entity.Ciudad = Entity.Ciudad;
                        _Entity.Pais = Entity.Pais;


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
        public int Count()
        {
            int size = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    size = db.Direccion.Count();
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
                    string query = string.Format("select * from Direccion {0}", filter);
                    var result = db.Direccion.SqlQuery(query).Count();
                    size = result;
                }
            }
            catch (IOException)
            {
                return 0;
            }
            return size;
        }
        public List<DireccionRequest> Get(string var)
        {
            List<DireccionRequest> list = new List<DireccionRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_FROM,var);
                list = (from d in db.Direccion.SqlQuery(query)

                        select new DireccionRequest
                        {

                            Id = d.Id,
                            Calle = d.Calle,
                            CodigoPostal = d.CodigoPostal,
                            Ciudad = d.Ciudad,
                            Pais = d.Pais


                        }).ToList();
            }
            return list;
        }
        public List<DireccionRequest> Get(string var, int pag, int elements)
        {
            List<DireccionRequest> list = new List<DireccionRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_FROM, var);
                list = (from d in db.Direccion.SqlQuery(query)

                        select new DireccionRequest
                        {

                            Id = d.Id,
                            Calle = d.Calle,
                            CodigoPostal = d.CodigoPostal,
                            Ciudad = d.Ciudad,
                            Pais = d.Pais


                        }).Skip(pag).Take(elements).ToList();
            }
            return list;
        }

        public DireccionRequest GetWhere(string filter)
        {
            DireccionRequest list = new DireccionRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                string query = string.Format(SELECT_FROM, filter);
                list = (from d in db.Direccion.SqlQuery(query)

                        select new DireccionRequest
                        {

                            Id = d.Id,
                            Calle = d.Calle,
                            CodigoPostal = d.CodigoPostal,
                            Ciudad=d.Ciudad,
                            Pais = d.Pais


                        }).FirstOrDefault();
            }
            return list;
        }
    }
}