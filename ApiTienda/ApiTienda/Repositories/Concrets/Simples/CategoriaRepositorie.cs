using ApiTienda.Models;
using ApiTienda.Models.Request.Abstract;
using ApiTienda.Repositories.Abstracts;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiTienda.Repositories.Concrets
{
    public class CategoriaRepositorie : ICategoriaRepositorie
    {
        private string SELECT_FROM = "Select * from Categoria where {0} ;";
        public string Delete(int Id)
        {
            try
            {
                Categoria Entity;
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    if ((Entity = db.Categoria.Find(Id))!= null)
                    {
                        db.Categoria.Remove(Entity);
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
        public List<CategoriaRequest> Get()
        {
            List<CategoriaRequest> list = new List<CategoriaRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Categoria
                        select new CategoriaRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre,
                            Id_Categoria_Padre= d.Id_Categoria_Padre

                        }).ToList();
            }
            return list;
        }
        public List<CategoriaRequest> Get(int Page, int Elements)
        {
            List<CategoriaRequest> list = new List<CategoriaRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                
        
                list = (from d in db.Categoria
                        orderby d.Id
                        select new CategoriaRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre,
                            Id_Categoria_Padre = d.Id_Categoria_Padre


                        }) .Skip(Page).Take(Elements).ToList() ;
            }
            return list;
        }
        public List<CategoriaRequest> GetSubcategorias(int idCategorie)
        {
            List<CategoriaRequest> list = new List<CategoriaRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                list = (from d in db.Categoria
                        where d.Id_Categoria_Padre==idCategorie
                        select new CategoriaRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre,
                            Id_Categoria_Padre = d.Id_Categoria_Padre

                        }).ToList();
            }
            return list;
        }
        public CategoriaRequest Get(int id)
        {
            Categoria Entity;
            using (TiendaDBEntities db = new TiendaDBEntities())
            {
                Entity = db.Categoria.Find(id);

                if (Entity != null)
                {
                    CategoriaRequest request = new CategoriaRequest
                    {
                        Id = Entity.Id,
                        Nombre = Entity.Nombre,
                        Id_Categoria_Padre = Entity.Id_Categoria_Padre
                    };
                    return request;
                }
            }

            return null;
        }
        public int Post(CategoriaRequest Entity)
        {
            Categoria _Categorie;
            if (Entity.Id_Categoria_Padre == 0)
            {
                Entity.Id_Categoria_Padre = null;
            }
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    _Categorie = new Categoria
                    {
                        Nombre = Entity.Nombre,
                        Id_Categoria_Padre=Entity.Id_Categoria_Padre
                    };
                    db.Categoria.Add(_Categorie);
                    db.SaveChanges();
                }
                return (_Categorie.Id);
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            catch (IOException )
            {
                return 0;
            }
        }
        public int Update(CategoriaRequest Entity)
        {
            int id = 0;
            try
            {
                using (TiendaDBEntities db = new TiendaDBEntities())
                {
                    Categoria _categorie =
                        db.Categoria.Find(Entity.Id);

                    if (_categorie != null)
                    {
                        _categorie.Id = Entity.Id;
                        _categorie.Nombre = Entity.Nombre;
                        _categorie.Id_Categoria_Padre = Entity.Id_Categoria_Padre;
                        db.SaveChanges();

                        id= _categorie.Id;
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
                    size =db.Categoria.Count();
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
                    string query = string.Format("select * from Categoria {0}", filter);
                    var result = db.Categoria.SqlQuery(query).Count();
                    size =result;
                }
            }
            catch (IOException)
            {
           
            }
            return size;
        }
        public List<CategoriaRequest> Get(string filter)
        {
            List<CategoriaRequest> list = new List<CategoriaRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                var query = string.Format(SELECT_FROM, filter);
                 list = (from d in db.Categoria.SqlQuery(query)
                        orderby d.Id
                        select new CategoriaRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre,
                            Id_Categoria_Padre = d.Id_Categoria_Padre


                        }).ToList();
            }
            return list;
        }
        public List<CategoriaRequest> Get(string filter, int pag, int elements)
        {
            List<CategoriaRequest> list = new List<CategoriaRequest>();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                var query = string.Format(SELECT_FROM,filter);
                list = (from d in db.Categoria.SqlQuery(query)
                        orderby d.Id
                        select new CategoriaRequest
                        {
                            Id = d.Id,
                            Nombre = d.Nombre,
                            Id_Categoria_Padre = d.Id_Categoria_Padre


                        }).Skip(pag).Take(elements).ToList();
            }
            return list;
        }

        public CategoriaRequest GetWhere(string filter)
        {
            CategoriaRequest item = new CategoriaRequest();
            using (TiendaDBEntities db = new TiendaDBEntities())
            {

                var query = string.Format(SELECT_FROM, filter);
                try
                {

                    item = (from d in db.Categoria.SqlQuery(query)
                            select new CategoriaRequest
                            {
                                Id = d.Id,
                                Nombre = d.Nombre,
                                Id_Categoria_Padre = d.Id_Categoria_Padre


                            }).FirstOrDefault(null);
                }
                catch (ArgumentNullException)
                {
                    return null;
                }
           
            }
            return item;
        }
    }
}