using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FindingATournament.Entities;
using FindingATournament.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FindingATournament.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class ClubsController : ControllerBase
    {
        private readonly IClubService _service;

        public ClubsController(IClubService service) // Activar servicio en Startup.cs
        {
            _service = service;
        }
        
        // Los clubs que tenemos disponibles son los que se encuentran
        //temporalmente en el repositorio de clubs.
        
        // Aqui devuelve todos los clubs empaquetados en formato JSON
        [HttpGet, Route("getClubs")]
        public async Task<IActionResult> GetClubs()
        {
            var clubs = await _service.GetAllClub();
            return Ok(clubs);
        }

        // Aqui devuelve el primer club empaquetado en formato JSON
        [HttpGet,Route("getFirstClub")]
        public async Task<IActionResult> GetClub()
        {
            var firstClub = await _service.GetFirstClub();
            return Ok(firstClub);
        }
        
    }
}