using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDesktop.Models;
using TiendaDesktop.Models.Abstractas;

namespace TiendaDesktop.Core.Repositories
{
    public interface IRepositorie<T> where T : class, IEntidad, new()
    {
        string Delete(T Entity);
        int Put(T Entity);
        int Post(T Entity);
        Task <List<T>> Get();
        Task<int> Count();
        Task<int> Count(string filter);
        Task<List<T>> Get(int pag, int elements);
        Task<List<T>> Get(string filter);
        Task<List<T>> Get(string filter,int pag, int elements);
        Task<T> Get(int id);
        Task<T> GetWhere( string filter);

    }
}
