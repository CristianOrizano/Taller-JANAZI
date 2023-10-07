using Jazani.Taller.Aplication.Mc.Dtos.Investmentconcepts;
using Jazani.Taller.Aplication.Mc.Dtos.Investments;
using Jazani.Taller.Aplication.Mc.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JAZANI_TALLER_Orizano.Controllers.Mc
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestmentController : ControllerBase
    {
        private readonly IInvestmentService _invesmenService;
        public InvestmentController(IInvestmentService invesmeService)
        {
            _invesmenService = invesmeService;
        }

        // GET: api/<InvestmentController>
        [HttpGet]
        public async Task<IEnumerable<InvestmentDto>> Get()
        {
            return await _invesmenService.FindAllAsync();
        }

        // GET api/<InvestmentController>/5
        [HttpGet("{id}")]
        public async Task<InvestmentDto> Get(int id)
        {
            return await _invesmenService.FindByIdAsync(id);
        }

        // POST api/<InvestmentController>
        [HttpPost]
        public async Task<InvestmentDto> Post([FromBody] InvestmentSaveDto invesSaveDto)
        {
            return await _invesmenService.CreateAsync(invesSaveDto);
        }

        // PUT api/<InvestmentController>/5
        [HttpPut("{id}")]
        public async Task<InvestmentDto> Put(int id, [FromBody] InvestmentSaveDto invesmeSaveDto)
        {
            return await _invesmenService.EditAsync(id, invesmeSaveDto);
        }

        // DELETE api/<InvestmentController>/5
        [HttpDelete("{id}")]
        public async Task<InvestmentDto> Delete(int id)
        {
            return await _invesmenService.DisabledAsync(id);
        }
    }
}
