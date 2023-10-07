using Jazani.Taller.Aplication.Mc.Dtos.Auctionareas;
using Jazani.Taller.Aplication.Mc.Dtos.Investmentconcepts;
using Jazani.Taller.Aplication.Mc.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JAZANI_TALLER_Orizano.Controllers.Mc
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestmentconceptController : ControllerBase
    {
        private readonly IInvestmentconceptService _invesmenService;
        public InvestmentconceptController(IInvestmentconceptService invesmeService)
        {
            _invesmenService = invesmeService;
        }

        // GET: api/<InvestmentconceptController>
        [HttpGet]
        public async Task<IEnumerable<InvestmentconceptDto>> Get()
        {
            return await _invesmenService.FindAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<InvestmentconceptDto> Get(int id)
        {
            return await _invesmenService.FindByIdAsync(id);
        }

        // POST api/<InvestmentconceptController>
        [HttpPost]
        public async Task<InvestmentconceptDto> Post([FromBody] InvestmentconceptSaveDto invesSaveDto)
        {
            return await _invesmenService.CreateAsync(invesSaveDto);
        }

        // PUT api/<InvestmentconceptController>/5
        [HttpPut("{id}")]
        public async Task<InvestmentconceptDto> Put(int id, [FromBody] InvestmentconceptSaveDto invesmeSaveDto)
        {
            return await _invesmenService.EditAsync(id, invesmeSaveDto);
        }

        // DELETE api/<InvestmentconceptController>/5
        [HttpDelete("{id}")]
        public async Task<InvestmentconceptDto> Delete(int id)
        {
            return await _invesmenService.DisabledAsync(id);
        }
    }
}
