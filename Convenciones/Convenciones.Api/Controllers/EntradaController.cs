using Convenciones.Dal;
using Convenciones.Domain.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Convenciones.Api.Controllers
{
    [ApiController]
    [Route("entrada")]
    public class EntradaController : Controller
    {
        private readonly ILogger<EntradaController> _logger;
        private readonly ConvencionesDBContext _dbContext;
        private readonly IEntradaService _service;

        public EntradaController(ILogger<EntradaController> logger, ConvencionesDBContext dBContext, IEntradaService service)
        {
            _logger = logger;
            _dbContext = dBContext;
            _service = service;
        }

        [HttpGet("GetEntradas")]
        public IActionResult GetEntradas()
        {
            try
            {
                var entradas = _service.GetEntradas(_dbContext);
                if (entradas.Count == 0)
                {
                    _logger.LogInformation("No se encontró ninguna entrada - {loginTime}", DateTime.Now);
                    return NotFound();
                }
                _logger.LogInformation("Retorno de entradas correcto - {loginTime}", DateTime.Now);
                return Ok(entradas);
            }
            catch (Exception)
            {
                _logger.LogInformation("Error Encontrado - {loginTime}", DateTime.Now);
                return StatusCode(500, "An error has ocurred");
            }
        }
        [HttpGet("GetEntrada")]
        public IActionResult GetEntrada(string slug)
        {
            try
            {
                var entradas = _service.GetEntrada(_dbContext, slug);
                if (entradas.Count == 0)
                {
                    _logger.LogInformation("No se encontró ningún resultado para: {titulo} - {loginTime}", slug, DateTime.Now);
                    return NotFound();
                }
                _logger.LogInformation("Se encontraron {cantidad} resultados para: {titulo} - {loginTime}", entradas.Count, slug, DateTime.Now);
                return Ok(entradas);
            }
            catch (Exception)
            {
                _logger.LogInformation("Error Encontrado - {loginTime}", DateTime.Now);
                return StatusCode(500, "An error has ocurred");
            }
        }
        [HttpGet("GetBusqueda")]
        public IActionResult GetBusqueda(string texto)
        {
            try
            {
                var entradas = _service.GetBusqueda(_dbContext, texto);
                if (entradas.Count == 0)
                {
                    _logger.LogInformation("No se encontró ningún resultado para: {titulo} - {loginTime}", texto, DateTime.Now);
                    return NotFound();
                }
                _logger.LogInformation("Se encontraron {cantidad} resultados para: {titulo} - {loginTime}", entradas.Count, texto, DateTime.Now);
                return Ok(entradas);
            }
            catch (Exception)
            {
                _logger.LogInformation("Error Encontrado - {loginTime}", DateTime.Now);
                return StatusCode(500, "An error has ocurred");
            }
        }
        [HttpGet("GetEtiqueta")]
        public IActionResult GetEtiqueta(string etiqueta)
        {
            try
            {
                var entradas = _service.GetEtiqueta(_dbContext, etiqueta);
                if (entradas.Count == 0)
                {
                    _logger.LogInformation("No se encontró ningún resultado para: {titulo} - {loginTime}", etiqueta, DateTime.Now);
                    return NotFound();
                }
                _logger.LogInformation("Se encontraron {cantidad} resultados para: {titulo} - {loginTime}", entradas.Count, etiqueta, DateTime.Now);
                return Ok(entradas);
            }
            catch (Exception)
            {
                _logger.LogInformation("Error Encontrado - {loginTime}", DateTime.Now);
                return StatusCode(500, "An error has ocurred");
            }
        }
    }
}
