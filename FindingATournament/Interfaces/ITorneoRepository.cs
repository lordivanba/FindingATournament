using System.Collections.Generic;
using System.Threading.Tasks;
using FindingATournament.Entities;
using FindingATournament.Repositories;

namespace FindingATournament.Interfaces
{
    public interface ITorneoRepository
    {
        //Definimos la interfaz con la cual obtendremos todos los torneos de nuestro repositorio
        Task<IEnumerable<Torneo>> GetAll();
    }
}