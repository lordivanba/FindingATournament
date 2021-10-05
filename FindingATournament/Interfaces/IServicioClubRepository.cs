using System.Collections.Generic;
using System.Threading.Tasks;
using FindingATournament.Entities;

namespace FindingATournament.Interfaces
{
    public interface IServicioClubRepository
    {
        Task<IEnumerable<ServicioClub>> GetAll();
    }
}