using Jazani.Taller.Aplication.Geo.Services;
using Jazani.Taller.Aplication.Mc.Dtos.Auctionareas;
using Jazani.Taller.Aplication.Soc.Dtos.Holders;
using Jazani.Taller.Aplication.Soc.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JAZANI_TALLER_Orizano.Controllers.Soc
{
    [Route("api/[controller]")]
    [ApiController]
    public class HolderController : ControllerBase
    {
        private readonly IHolderService _holderService;
        public HolderController(IHolderService holderService)
        {
            _holderService = holderService;
        }

        // GET: api/<HolderController>
        [HttpGet]
        public async Task<IEnumerable<HolderDto>> Get()
        {
            return await _holderService.FindAllAsync();
        }


    }
}
