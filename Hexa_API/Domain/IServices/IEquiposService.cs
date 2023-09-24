using Hexa_API.Domain.Models;

namespace Hexa_API.Domain.IServices
{
    public interface IEquiposService
    {
        Task<List<Equipos>> GetTeams();
    }
}
