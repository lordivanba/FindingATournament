using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FindingATournament.Entities;

namespace FindingATournament.Interfaces
{
    public interface IClubRepository
    {
        //Definimos la interfaz con la cual obtendremos todos los clubs de nuestro repositorio
        Task<IEnumerable<Club>> GetAll();
    }
}