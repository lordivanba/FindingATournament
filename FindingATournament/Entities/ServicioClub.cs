using System;

namespace FindingATournament.Entities
{
    public record ServicioClub(
        string Disciplina,
        string Horario,
        int PersonasPermitidas,
        Boolean RequiereEquipoEspecial,
        Boolean CapacidadesDiferentes,
        DateTime FechaRegistro
        );
}