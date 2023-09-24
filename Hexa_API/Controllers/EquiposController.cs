using Hexa_API.Domain.IServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hexa_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquiposController : ControllerBase
    {
        private readonly IEquiposService _equiposServices;

        public EquiposController(IEquiposService equiposServices)
        {
            _equiposServices = equiposServices;

        }

        // GET: api/<EquiposController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("GetTeams")]
        public async Task<IActionResult> GetTeams()
        {
            try
            {
                var teams = await _equiposServices.GetTeams();
                return Ok(teams);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        // GET api/<EquiposController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EquiposController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EquiposController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EquiposController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
