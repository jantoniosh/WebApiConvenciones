using Convenciones.Dal;
using System.Collections.Generic;


namespace Convenciones.Domain.Abstractions
{
    public interface IEntradaService
    {
        List<Entradas> GetEntradas(ConvencionesDBContext dbContext);
        List<Entradas> GetEntrada(ConvencionesDBContext dbContext, string slug);
        List<Entradas> GetBusqueda(ConvencionesDBContext dbContext, string texto);
        List<Entradas> GetEtiqueta(ConvencionesDBContext dbContext, string etiqueta);
    }
}
