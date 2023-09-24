using Hexa_API.Domain.IRepositories;
using Hexa_API.Domain.Models;
using Hexa_API.DTOS;
using Hexa_API.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Hexa_API.Persistence.Repositories
{
    public class JugadoresRepository: IJugadoresRepository
    {
        private readonly AplicationDbContext _context;
        public JugadoresRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Jugadores>> GetPlayers()
        {
            var players = await _context.Jugadores.ToListAsync();
            return players;
           
        }

        public async Task SavePlayer(Jugadores player)
        {
            _context.Add(player);
            await _context.SaveChangesAsync();

        }

        public async Task<Equipos> GetTeamId(string IdEquipo)
        {
            var team = _context.Equipos.Where(e => e.IdEquipo == IdEquipo).FirstOrDefault();
            return team;
        }

        public async Task<bool> ValidateExistence(JugadorDTO player)
        {
            var validateExistence = await _context.Jugadores.AnyAsync(u => u.Nombres == player.Nombres);
            return validateExistence;
        }

        public async Task UpdatePlayer(Jugadores player)
        {
            _context.Jugadores.Update(player);
            await _context.SaveChangesAsync();

        }




    }
}
