using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindingATournament.Entities;
using FindingATournament.Interfaces;

namespace FindingATournament.Services
{
    public class TorneoService : ITorneoService
    {
        private readonly ITorneoRepository _repository;
        
        //Constructor de nuestro servicio el cual recibe los torneos guardados dentro del repositorio
        public TorneoService(ITorneoRepository repository)
        {
            _repository = repository;
        }
        
        //Este servicio consume la interfaz del repositorio para poder retornar todos los torneos
        public async Task<IEnumerable<Torneo>> GetAllTorneo()
        {
            return await _repository.GetAll();
        }
        //Este servicio consume la interfaz del repositorio para poder retornar el primer torneo
        public async Task<Torneo> GetFirstTorneo()
        {
            var lst = await _repository.GetAll();
            return lst.FirstOrDefault();
        }
    }
}