using System;

namespace FindingATournament.Entities
{
    //En este apartado definimos los atributos de la entidad Club
    public record Club(
        string Name,
        string Address,
        string PhoneNumber,
        DateTime RegisterDate,
        Boolean Status 
        );
    
}