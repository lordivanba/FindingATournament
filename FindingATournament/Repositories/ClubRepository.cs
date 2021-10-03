using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindingATournament.Entities;
using FindingATournament.Interfaces;

namespace FindingATournament.Repositories
{
    public class ClubRepository : IClubRepository
    {
        // Esta lista de clubs es lo que pasará por la interfaz IClubsRepository
        public async Task<IEnumerable<Club>> GetAll() 
        {
            var clubs = Enumerable.Range(1, 10)
                .Select(club => new Club(
                    Name:$"Club_{club}",
                    Address:$"Direccion_{club}",
                    PhoneNumber:$"999-999-999{club}",
                    RegisterDate: DateTime.Now, 
                    Status: true
                ));
            await Task.Delay(1000);
            return clubs;
        }
    }
}