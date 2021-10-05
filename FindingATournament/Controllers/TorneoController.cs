using System.Collections.Generic;
using System.Threading.Tasks;
using FindingATournament.Entities;
using FindingATournament.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FindingATournament.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class TorneoController : ControllerBase
    {
        private readonly ITorneoService _service;

        public TorneoController(ITorneoService service) // Activar servicio en Startup.cs
        {
            _service = service;
        }
        
        // Los torneos que tenemos disponibles son los que se encuentran
        //temporalmente en el repositorio de torneos.

        // Aqui devuelve todos los torneos empaquetados en formato JSON.
        [HttpGet, Route("GetTorneos")]
        public async Task<IActionResult> GetTorneos()
        {
            var torneos = await _service.GetAllTorneo();
            return Ok(torneos);
        }

        // Aqui devuelve el primer torneo empaquetado en formato JSON
        [HttpGet, Route("GetFirstTorneo")]
        public async Task<IActionResult> GetFirstTorneo()
        {
            var firstTorneo = await _service.GetFirstTorneo();
            return Ok(firstTorneo);
        }
    }
}