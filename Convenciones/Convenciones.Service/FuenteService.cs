using Convenciones.Dal;
using Convenciones.Domain.Abstractions;
using System.Collections.Generic;
using System.Linq;


namespace Convenciones.Service
{
    public class FuenteService : IFuenteService
    {
        public List<Fuentes> GetFuentes(ConvencionesDBContext dbContext)
        {
            return dbContext.fuentes.ToList();
        }
    }
}
