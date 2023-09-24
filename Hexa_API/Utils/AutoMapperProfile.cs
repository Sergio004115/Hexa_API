using AutoMapper;
using Hexa_API.Domain.Models;
using Hexa_API.DTOS;

namespace Hexa_API.Utils
{
    public class AutoMapperProfile: Profile
    {

        public AutoMapperProfile() 
        {
            CreateMap<JugadorDTO, Jugadores>();
        }
       
    }
}
