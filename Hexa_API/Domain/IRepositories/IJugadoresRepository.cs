using Hexa_API.Domain.Models;
using Hexa_API.DTOS;

namespace Hexa_API.Domain.IRepositories
{
    public interface IJugadoresRepository
    {
        Task<List<Jugadores>> GetPlayers();
        Task SavePlayer(Jugadores jugadores);
        Task<Equipos> GetTeamId(string IdEquipo);

        Task<bool> ValidateExistence(JugadorDTO player);
        Task UpdatePlayer(Jugadores player);
    }
}
