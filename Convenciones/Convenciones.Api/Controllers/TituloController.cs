using Convenciones.Dal;
using Convenciones.Domain.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Convenciones.Api.Controllers
{
    [ApiController]
    [Route("titulo")]
    public class TituloController : ControllerBase
    {
        private readonly ILogger<TituloController> _logger;
        private readonly ConvencionesDBContext _dbContext;
        private readonly ITituloService _service;
        public TituloController(ILogger<TituloController> logger, ConvencionesDBContext dBContext, ITituloService service)
        {
            _logger = logger;
            _dbContext = dBContext;
            _service = service;
        }
        [HttpGet("GetTitulos")]
        public IActionResult GetTitulos()
        {
            try
            {
                var titulos = _service.GetTitulos(_dbContext);
                if (titulos.Count == 0)
                {
                    _logger.LogInformation("No se encontró ninguna fuente - {loginTime}", DateTime.Now);
                    return NotFound();
                }
                _logger.LogInformation("Retorno de fuente correcto - {loginTime}", DateTime.Now);
                return Ok(titulos);
            }
            catch (Exception e)
            {
                _logger.LogInformation("Error Encontrado - {loginTime}", DateTime.Now);
                return StatusCode(500, e);
            }
        }
        [HttpGet("GetTitulo")]
        public IActionResult GetTitulo(string titulo)
        {
            try
            {
                var titulos = _service.GetTitulo(_dbContext, titulo);
                if (titulos.Count == 0)
                {
                    _logger.LogInformation("No se encontró ningún resultado para: {titulo} - {loginTime}", titulo, DateTime.Now);
                    return NotFound();
                }
                _logger.LogInformation("Se encontraron {cantiddad} resultados para: {titulo} - {loginTime}", titulos.Count, titulo, DateTime.Now);
                return Ok(titulos);
            }
            catch (Exception)
            {
                _logger.LogInformation("Error Encontrado - {loginTime}", DateTime.Now);
                return StatusCode(500, "An error has ocurred");
            }
        }
    }
}
