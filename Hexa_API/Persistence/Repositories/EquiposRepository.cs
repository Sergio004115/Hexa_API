using Hexa_API.Domain.IRepositories;
using Hexa_API.Domain.Models;
using Hexa_API.DTOS;
using Hexa_API.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Hexa_API.Persistence.Repositories
{
    public class EquiposRepository: IEquiposRepository
    {
        private readonly AplicationDbContext _context;
        public EquiposRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Equipos>> GetTeams()
        {
            var teams = await _context.Equipos.ToListAsync();
            return teams;
        }
    }
}
