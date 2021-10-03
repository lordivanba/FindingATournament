using System;

namespace FindingATournament.Entities
{
    //En este apartado definimos los atributos de la entidad Torneo
    public record Torneo(
            string Disciplina, 
            int NumeroEquipos,
            int DisponibilidadLugares,
            double CostoInscripcion,
            string Bases, 
            int NumeroRondas,
            string TipoTorneo, 
            DateTime FechaRegistro, 
            string Resultado, 
            string Status
            );
}