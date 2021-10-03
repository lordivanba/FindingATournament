using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindingATournament.Entities;
using FindingATournament.Interfaces;

namespace FindingATournament.Services
{
    public class ClubService : IClubService
    {
        private readonly IClubRepository _repository;

        //Constructor de nuestro servicio el cual recibe los clubs guardados dentro del repositorio
        public ClubService(IClubRepository repository)
        {
            _repository = repository;
        }

        //Este servicio consume la interfaz del repositorio para poder retornar todos los clubs
        public async Task<IEnumerable<Club>> GetAllClub()
        {
            return await _repository.GetAll();
        }

        //Este servicio consume la interfaz del repositorio para poder retornar el primer club
        public async Task<Club> GetFirstClub()
        {
            var lst = await _repository.GetAll();
            return lst.FirstOrDefault();
        }

    }
}