using Hexa_API.Domain.IRepositories;
using Hexa_API.Domain.IServices;
using Hexa_API.Domain.Models;
using Hexa_API.DTOS;

namespace Hexa_API.Services
{
    public class JugadoresService: IJugadoresServices
    {
        private readonly IJugadoresRepository _jugadoresRepository;
        public JugadoresService(IJugadoresRepository jugadoresRepository)
        {
            _jugadoresRepository = jugadoresRepository;
        }


        public async Task<List<Jugadores>> GetPlayers()
        {
            return await _jugadoresRepository.GetPlayers();
        }

        public async Task SavePlayer(Jugadores player)
        {
            await _jugadoresRepository.SavePlayer(player);
        }

        public async Task<Equipos> GetTeamId(string IdEquipo)
        {
            return await _jugadoresRepository.GetTeamId(IdEquipo);

        }

        public async Task<bool> ValidateExistence(JugadorDTO player)
        {
            return await _jugadoresRepository.ValidateExistence(player);
        }

        public async Task UpdatePlayer(Jugadores player)
        {
            await _jugadoresRepository.UpdatePlayer(player);
        }







    }
}
