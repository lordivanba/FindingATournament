using System.Collections.Generic;
using System.Threading.Tasks;
using FindingATournament.Entities;

namespace FindingATournament.Interfaces
{
    public interface IServicioClubService
    {
        Task<IEnumerable<ServicioClub>> GetAllServicioClub();
        Task<ServicioClub> GetFirstServicioClub();
    }
}