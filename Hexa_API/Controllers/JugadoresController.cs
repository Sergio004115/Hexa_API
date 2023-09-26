using AutoMapper;
using Hexa_API.Domain.IServices;
using Hexa_API.Domain.Models;
using Hexa_API.DTOS;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hexa_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JugadoresController : ControllerBase
    {
        private readonly IJugadoresServices _jugadoresServices;
        private readonly IMapper _mapper;

        public JugadoresController(IJugadoresServices jugadoresServices, IMapper mapper)
        {
            _jugadoresServices = jugadoresServices;
            _mapper = mapper;

        }

        // GET: api/<JugadoresController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("GetPlayers")]
        public async Task<IActionResult> GetPlayers()
        {
            try
            {
                var players = await _jugadoresServices.GetPlayers();
                return Ok(new {Ok = true, data = players});
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        // GET api/<JugadoresController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<JugadoresController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPost]
        [Route("InsertNewPlayer")]
        public async Task<IActionResult> InsertNewPlayer([FromBody] JugadorDTO playerDTO)
        {
            try
            {
                var playesExist = await _jugadoresServices.ValidateExistence(playerDTO);

                if(playesExist)
                {
                    Console.Write("Prueba pipeline");
                    return Ok(false);
                }
                else
                {
                    var player = _mapper.Map<Jugadores>(playerDTO);
                    //TODO BUSCAR EQUIPO
                    var team = await _jugadoresServices.GetTeamId(player.IdEquipo);
                    player.IdJugador = Guid.NewGuid().ToString();
                    player.CodigoEquipo = team.Codigo;
                    player.NombreEquipo = team.Nombre;

                    if(player.campeonatos == null)
                    {
                        player.campeonatos = "No aplica";
                    }

                    await _jugadoresServices.SavePlayer(player);
                    return Ok(true);
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
        // PUT api/<JugadoresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpPut]
        [Route("UpdatePlayer")]
        public async Task<IActionResult> UpdatePlayer([FromBody] JugadorDTO jugadorDTO)
        {
            try
            {
                var player = _mapper.Map<Jugadores>(jugadorDTO);

                var teamEdit = await _jugadoresServices.GetTeamId(player.IdEquipo);
                player.IdEquipo = teamEdit.IdEquipo;
                player.CodigoEquipo = teamEdit.Codigo;
                player.NombreEquipo = teamEdit.Nombre;
                player.IdJugador = jugadorDTO.idJugador;

                await _jugadoresServices.UpdatePlayer(player);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        // DELETE api/<JugadoresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
