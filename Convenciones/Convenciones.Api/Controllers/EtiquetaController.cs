using Convenciones.Dal;
using Convenciones.Domain.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Convenciones.Api.Controllers
{
    [ApiController]
    [Route("etiqueta")]
    public class EtiquetaController : ControllerBase
    {
        private readonly ILogger<TituloController> _logger;
        private readonly ConvencionesDBContext _dbContext;
        private readonly IEtiquetaService _service;
        public EtiquetaController(ILogger<TituloController> logger, ConvencionesDBContext dBContext, IEtiquetaService service)
        {
            _logger = logger;
            _dbContext = dBContext;
            _service = service;
        }
        /// <summary>
        /// Muestra todas las etiquetas de la base de datos
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetEtiquetas")]
        public IActionResult GetEtiquetas()
        {
            try
            {
                var etiquetas = _service.GetEtiquetas(_dbContext);
                if (etiquetas.Count == 0)
                {
                    _logger.LogWarning("No se encontró ninguna etiqueta - {loginTime}", DateTime.Now);
                    return NotFound();
                }
                _logger.LogInformation("Retorno de etiquetas correcto - {loginTime}", DateTime.Now);
                return Ok(etiquetas);
            }
            catch (Exception e)
            {
                _logger.LogError("Error Encontrado - {loginTime}", DateTime.Now);
                return StatusCode(500, e);
            }
        }
    }
}
