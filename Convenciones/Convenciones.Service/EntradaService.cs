using Convenciones.Dal;
using Convenciones.Domain.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace Convenciones.Service
{
    public class EntradaService : IEntradaService
    {
        public List<Entradas> GetEntradas(ConvencionesDBContext dbContext)
        {
            return dbContext.entradas.ToList();
        }
        public List<Entradas> GetEntrada(ConvencionesDBContext dbContext, string slug)
        {
            return dbContext.entradas.Where(b => b.url.Equals(slug)).ToList();
        }
        public List<Entradas> GetBusqueda(ConvencionesDBContext dbContext, string texto)
        {
            return dbContext.entradas.Where(b => b.titulo.Contains(texto) || b.subtitulo.Contains(texto) || b.subsubtitulo.Contains(texto)).ToList();
        }
        public List<Entradas> GetEtiqueta(ConvencionesDBContext dbContext, string etiqueta)
        {
            return dbContext.entradas.Where(b => b.etiquetas.Contains(etiqueta)).ToList();
        }
    }
}
