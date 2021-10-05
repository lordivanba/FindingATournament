using System.Collections.Generic;
using System.Threading.Tasks;
using FindingATournament.Entities;
using FindingATournament.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FindingATournament.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class ServicioClubController : Controller
    {
        private readonly IServicioClubService _service;

        public ServicioClubController(IServicioClubService service)
        {
            _service = service;
        }

        [HttpGet, Route("GetServicios")]
        public async Task<IActionResult> GetServicios()
        {
            var servicios = await _service.GetAllServicioClub();
            return Ok(servicios);
        }

        [HttpGet, Route("GetFirstServicio")]
        public async Task<IActionResult> GetFirstServicio()
        {
            var firstServicio = await _service.GetFirstServicioClub();
            return Ok(firstServicio);
        }

    }
}