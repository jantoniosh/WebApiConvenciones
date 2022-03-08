using Convenciones.Dal;
using Convenciones.Domain.Abstractions;
using System.Collections.Generic;
using System.Linq;


namespace Convenciones.Service
{
    public class EtiquetaService : IEtiquetaService
    {
        private readonly ConvencionesDBContext _dbContext;
        public EtiquetaService(ConvencionesDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public List<Etiquetas> GetEtiquetas()
        {
            return _dbContext.etiquetas.ToList();
        }
    }
}
