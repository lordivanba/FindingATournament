using System.Collections.Generic;
using System.Threading.Tasks;
using FindingATournament.Entities;

namespace FindingATournament.Interfaces
{
    public interface ITorneoService
    {
        //Aqui definimos la interfaz para los comportamientos
        Task<IEnumerable<Torneo>> GetAllTorneo();
        Task<Torneo> GetFirstTorneo();
    }
}