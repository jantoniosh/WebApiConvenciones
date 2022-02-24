using Convenciones.Dal;
using Convenciones.Domain.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Convenciones.Api.Controllers
{
    [ApiController]
    [Route("fuentes")]
    public class FuenteController : ControllerBase
    {
        private readonly ILogger<TituloController> _logger;
        private readonly ConvencionesDBContext _dbContext;
        private readonly IFuenteService _service;
        public FuenteController(ILogger<TituloController> logger, ConvencionesDBContext dBContext, IFuenteService service)
        {
            _logger = logger;
            _dbContext = dBContext;
            _service = service;
        }
        [HttpGet("GetFuentes")]
        public IActionResult GetTitulos()
        {
            try
            {
                var fuentes = _service.GetFuentes(_dbContext);
                if (fuentes.Count == 0)
                {
                    _logger.LogInformation("No se encontró ninguna fuente - {loginTime}", DateTime.Now);
                    return NotFound();
                }
                _logger.LogInformation("Retorno de fuente correcto - {loginTime}", DateTime.Now);
                return Ok(fuentes);
            }
            catch (Exception e)
            {
                _logger.LogInformation("Error Encontrado - {loginTime}", DateTime.Now);
                return StatusCode(500, e);
            }
        }
    }
}
