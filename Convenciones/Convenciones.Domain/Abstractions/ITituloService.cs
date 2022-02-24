using Convenciones.Dal;
using System.Collections.Generic;

namespace Convenciones.Domain.Abstractions
{
    public interface ITituloService
    {
        List<Titulos> GetTitulos(ConvencionesDBContext dbContext);
        List<Titulos> GetTitulo(ConvencionesDBContext dbContext, string titulo);
    }
}
