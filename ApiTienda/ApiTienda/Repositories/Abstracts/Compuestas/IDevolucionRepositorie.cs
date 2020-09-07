using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTienda.Repositories.Abstracts
{
    interface IDevolucionRepositorie : IRepositorie<DevolucionRequest> 
    {
        List<DevolucionRequest> GetByDate(string date);
        List<DevolucionRequest> GetByDate(string date,int skip,int elements);

    }
}
