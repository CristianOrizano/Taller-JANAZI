using Jazani.Taller.Aplication.Mc.Dtos.Investmenttypes;
using Jazani.Taller.Aplication.Mc.Dtos.MiningConcessions;
using Jazani.Taller.Aplication.Mc.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JAZANI_TALLER_Orizano.Controllers.Mc
{
    [Route("api/[controller]")]
    [ApiController]
    public class MiningConcessionController : ControllerBase
    {
        private readonly IMiningConcessionService _miniconService;
        public MiningConcessionController(IMiningConcessionService miniconService)
        {
            _miniconService = miniconService;
        }

        // GET: api/<MiningConcessionController>
        [HttpGet]
        public async Task<IEnumerable<MiningConcessionDto>> Get()
        {
            return await _miniconService.FindAllAsync();
        }

        // GET api/<MiningConcessionController>/5
        [HttpGet("{id}")]
        public async Task<MiningConcessionDto> Get(int id)
        {
            return await _miniconService.FindByIdAsync(id);
        }

        // POST api/<MiningConcessionController>
        [HttpPost]
        public async Task<MiningConcessionDto> Post([FromBody] MiningConcessionSaveDto invesSaveDto)
        {
            return await _miniconService.CreateAsync(invesSaveDto);
        }

        // PUT api/<MiningConcessionController>/5
        [HttpPut("{id}")]
        public async Task<MiningConcessionDto> Put(int id, [FromBody] MiningConcessionSaveDto invesmeSaveDto)
        {
            return await _miniconService.EditAsync(id, invesmeSaveDto);
        }

        // DELETE api/<MiningConcessionController>/5
        [HttpDelete("{id}")]
        public async Task<MiningConcessionDto> Delete(int id)
        {
            return await _miniconService.DisabledAsync(id);
        }
    }
}
