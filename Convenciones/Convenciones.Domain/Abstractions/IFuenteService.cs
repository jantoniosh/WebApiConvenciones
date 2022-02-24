using Convenciones.Dal;
using System.Collections.Generic;


namespace Convenciones.Domain.Abstractions
{
    public interface IFuenteService
    {
        List<Fuentes> GetFuentes(ConvencionesDBContext dbContext);
    }
}
