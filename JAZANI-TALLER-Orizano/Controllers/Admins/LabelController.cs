using Jazani.Taller.Aplication.Admins.Dtos;
using Jazani.Taller.Aplication.Admins.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JAZANI_TALLER_Orizano.Controllers.Admins
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabelController : ControllerBase
    {
        private readonly ILabelService _labelService;
        public LabelController(ILabelService labelService)
        {
            _labelService = labelService;
        }

        // GET: api/<LabelController>
        [HttpGet]
        public async Task<IEnumerable<LabelDto>> Get()
        {
            return await _labelService.FindAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<LabelDto> Get(int id)
        {
            return await _labelService.FindByIdAsync(id);
        }

        // POST api/<LabelController>
        [HttpPost]
        public async Task<LabelDto> Post([FromBody] LabelSaveDto labelSaveDto)
        {
            return await _labelService.CreateAsync(labelSaveDto);
        }

        // PUT api/<LabelController>/5
        [HttpPut("{id}")]
        public async Task<LabelDto> Put(int id, [FromBody] LabelSaveDto labelSaveDto)
        {
            return await _labelService.EditAsync(id, labelSaveDto);
        }

        // DELETE api/<LabelController>/5
        [HttpDelete("{id}")]
        public async Task<LabelDto> Delete(int id)
        {
            return await _labelService.DisabledAsync(id);
        }
    }
}
