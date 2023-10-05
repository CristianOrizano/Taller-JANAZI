using Jazani.Taller.Aplication.Geo.Dtos.Districts;
using Jazani.Taller.Aplication.Geo.Services;
using Jazani.Taller.Aplication.Mc.Dtos.Auctionareas;
using Jazani.Taller.Aplication.Mc.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JAZANI_TALLER_Orizano.Controllers.Geo
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : ControllerBase
    {

        private readonly IDistrictService _districService;
        public DistrictController(IDistrictService distrciService)
        {
            _districService = distrciService;
        }

        // GET: api/<DistrictController>
        [HttpGet]
        public async Task<IEnumerable<DistrictDto>> Get()
        {
            return await _districService.FindAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<DistrictDto> Get(string id)
        {
            return await _districService.FindByIdAsync(id);
        }

    }
}
