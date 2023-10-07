using Jazani.Taller.Aplication.Ge.Dtos.MeasureUnits;
using Jazani.Taller.Aplication.Ge.Dtos.PeriodTypes;
using Jazani.Taller.Aplication.Ge.Services;
using Jazani.Taller.Domain.Ge.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JAZANI_TALLER_Orizano.Controllers.Ge
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeriodTypeController : ControllerBase
    {
        private readonly IPeriodTypeService _periodService;
        public PeriodTypeController(IPeriodTypeService perioService)
        {
            _periodService = perioService;
        }

        // GET: api/<PeriodTypeController>
        [HttpGet]
        public async Task<IEnumerable<PeriodTypeDto>> Get()
        {
            return await _periodService.FindAllAsync();
        }

        // GET api/<PeriodTypeController>/5
        [HttpGet("{id}")]
        public async Task<PeriodTypeDto> Get(int id)
        {
            return await _periodService.FindByIdAsync(id);
        }

        // POST api/<PeriodTypeController>
        [HttpPost]
        public async Task<PeriodTypeDto> Post([FromBody] PeriodTypeSaveDto inmeasuSaveDto)
        {
            return await _periodService.CreateAsync(inmeasuSaveDto);
        }

        // PUT api/<PeriodTypeController>/5
        [HttpPut("{id}")]
        public async Task<PeriodTypeDto> Put(int id, [FromBody] PeriodTypeSaveDto inmeasuSaveDto)
        {
            return await _periodService.EditAsync(id, inmeasuSaveDto);
        }

        // DELETE api/<PeriodTypeController>/5
        [HttpDelete("{id}")]
        public async Task<PeriodTypeDto> Delete(int id)
        {
            return await _periodService.DisabledAsync(id);
        }
    }
}
