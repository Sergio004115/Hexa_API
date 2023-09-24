using Hexa_API.Domain.IRepositories;
using Hexa_API.Domain.IServices;
using Hexa_API.Domain.Models;
using Hexa_API.Persistence.Repositories;

namespace Hexa_API.Services
{
    public class EquiposService: IEquiposService
    {
        private readonly IEquiposRepository _equiposRepository;
        public EquiposService(IEquiposRepository equiposRepository)
        {
            _equiposRepository = equiposRepository;
        }


        public async Task<List<Equipos>> GetTeams()
        {
            return await _equiposRepository.GetTeams();
        }
    }
}
