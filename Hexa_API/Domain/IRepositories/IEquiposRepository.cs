using Hexa_API.Domain.Models;

namespace Hexa_API.Domain.IRepositories
{
    public interface IEquiposRepository
    {
        Task<List<Equipos>> GetTeams();
    }
}
