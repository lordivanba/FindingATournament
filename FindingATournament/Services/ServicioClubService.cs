using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindingATournament.Entities;
using FindingATournament.Interfaces;

namespace FindingATournament.Services
{
    public class ServicioClubService : IServicioClubService
    {
        private readonly IServicioClubRepository _repository;

        public ServicioClubService(IServicioClubRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ServicioClub>> GetAllServicioClub()
        {
            return await _repository.GetAll();
        }

        public async Task<ServicioClub> GetFirstServicioClub()
        {
            var lst = await _repository.GetAll();
            return lst.FirstOrDefault();
        }
    }
}