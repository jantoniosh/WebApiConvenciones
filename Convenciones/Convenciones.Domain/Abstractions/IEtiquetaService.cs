using Convenciones.Dal;
using System.Collections.Generic;


namespace Convenciones.Domain.Abstractions
{
    public interface IEtiquetaService
    {
        List<Etiquetas> GetEtiquetas();
    }
}
