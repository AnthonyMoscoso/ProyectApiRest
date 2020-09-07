using ApiTienda.Controllers.Abstracts;
using ApiTienda.Models.Request.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTienda.Repositories.Abstracts
{
    interface IDireccionRepositorie : IRepositorie<DireccionRequest> 
    {

     /*   List<DireccionRequest> SearchByCodigoPostal(string codigoPostal);
        List<DireccionRequest> SearchByCodigoPostal(string codigoPostal, int pag, int elements);

        List<DireccionRequest> SearchByProvincia(string city);
        List<DireccionRequest> SearchByProvincia(string city, int pag, int elements);
        List<DireccionRequest> SearchBypoblacion(string poblacion);
        List<DireccionRequest> SearchBypoblacion(string poblacion, int pag, int elements);
        List<DireccionRequest> SearchByPais(string pais);
        List<DireccionRequest> SearchByPais(string pais, int pag, int elements);*/
    }
}
