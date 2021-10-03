using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FindingATournament.Entities;

namespace FindingATournament.Interfaces
{
    public interface IClubService
    {
        //Aqui definimos la interfaz para los comportamientos
        Task<IEnumerable<Club>> GetAllClub();
        
        Task<Club> GetFirstClub();
    }
}