using Convenciones.Dal;
using Convenciones.Domain.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace Convenciones.Service
{
    public class TituloService : ITituloService
    {
        public List<Titulos> GetTitulos(ConvencionesDBContext dbContext)
        {
            return dbContext.titulos.ToList();
        }
        public List<Titulos> GetTitulo(ConvencionesDBContext dbContext, string titulo)
        {
            return dbContext.titulos.Where(b => b.titulo.Contains(titulo)).ToList();
        }
    }
}
