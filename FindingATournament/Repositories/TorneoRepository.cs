using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindingATournament.Entities;
using FindingATournament.Interfaces;

namespace FindingATournament.Repositories
{
    public class TorneoRepository : ITorneoRepository
    {
        public async Task<IEnumerable<Torneo>> GetAll()
        {
            // Esta torneos de clubs es lo que pasará por la interfaz ITorneoRepository
            var torneos = Enumerable.Range(1, 10)
                .Select(torneo => new Torneo(
                    Disciplina: $"Disciplina_{torneo}",
                    NumeroEquipos: 10,
                    DisponibilidadLugares: 5,
                    CostoInscripcion: 125.50,
                    Bases: $"Bases_{torneo}",
                    NumeroRondas: 5,
                    TipoTorneo: $"Tipo_{torneo}",
                    FechaRegistro: DateTime.Now,
                    Resultado: $"Resultado_{torneo}",
                    Status: $"Status_{torneo}"
            ));
            await Task.Delay(1000);
            return torneos;
        }
    }
}