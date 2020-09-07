using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTienda.Repositories.Abstracts
{
    interface IRepositorie<T>
    {
        string Delete(int id);
        int Post(T Entity);
        int Update(T Entity);
        List<T> Get();
        int Count();
        int Count(string filter);
        List<T> Get(int page, int elements);
        List<T> Get(string filter);
        List<T> Get(string filter,int pag,int elements);
        T Get(int id);

        T GetWhere(string filter);
       
       

    }
}
