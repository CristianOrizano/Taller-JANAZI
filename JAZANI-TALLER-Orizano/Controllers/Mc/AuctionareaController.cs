using Jazani.Taller.Aplication.Admins.Dtos;
using Jazani.Taller.Aplication.Admins.Services;
using Jazani.Taller.Aplication.Admins.Services.Implementations;
using Jazani.Taller.Aplication.Mc.Dtos.Auctionareas;
using Jazani.Taller.Aplication.Mc.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JAZANI_TALLER_Orizano.Controllers.Mc
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionareaController : ControllerBase
    {
        private readonly IAuctionareaService _auctionService;
        public AuctionareaController(IAuctionareaService auctioService)
        {
            _auctionService = auctioService;
        }

        // GET: api/<AuctionareaController>
        [HttpGet]
        public async Task<IEnumerable<AuctionareaDto>> Get()
        {
            return await _auctionService.FindAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<AuctionareaDto> Get(int id)
        {
            return await _auctionService.FindByIdAsync(id);
        }

        // POST api/<AuctionareaController>
        [HttpPost]
        public async Task<AuctionareaDto> Post([FromBody] AuctionareaSaveDto auctioSaveDto)
        {
            return await _auctionService.CreateAsync(auctioSaveDto);
        }

        // PUT api/<AuctionareaController>/5
        [HttpPut("{id}")]
        public async Task<AuctionareaDto> Put(int id, [FromBody] AuctionareaSaveDto auctioSaveDto)
        {
            return await _auctionService.EditAsync(id, auctioSaveDto);
        }

        // DELETE api/<AuctionareaController>/5
        [HttpDelete("{id}")]
        public async Task<AuctionareaDto> Delete(int id)
        {
            return await _auctionService.DisabledAsync(id);
        }
    }
}
