using Convenciones.Dal;
using Convenciones.Domain.Abstractions;
using System.Collections.Generic;
using System.Linq;


namespace Convenciones.Service
{
    public class EtiquetaService : IEtiquetaService
    {
        public List<Etiquetas> GetEtiquetas(ConvencionesDBContext dbContext)
        {
            return dbContext.etiquetas.ToList();
        }
    }
}
