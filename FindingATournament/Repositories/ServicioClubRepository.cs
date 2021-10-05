using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using FindingATournament.Entities;
using FindingATournament.Interfaces;

namespace FindingATournament.Repositories
{
    public class ServicioClubRepository : IServicioClubRepository
    {
        public async Task<IEnumerable<ServicioClub>> GetAll()
        {
            var servicios = Enumerable.Range(1, 10)
                .Select(servicio => new ServicioClub(
                    Disciplina: $"Disciplina_{servicio}",
                    Horario: $"Horario_{servicio}",
                    PersonasPermitidas: servicio,
                    RequiereEquipoEspecial: false,
                    CapacidadesDiferentes: false,
                    FechaRegistro: DateTime.Now
                ));
            await Task.Delay(1000);
            return servicios;
        }
    }
}