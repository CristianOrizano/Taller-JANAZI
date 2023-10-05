using Jazani.Taller.Aplication.Admins.Dtos;
using Jazani.Taller.Aplication.Admins.Dtos.PermissionLabels;
using Jazani.Taller.Aplication.Admins.Services;
using Jazani.Taller.Aplication.Admins.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JAZANI_TALLER_Orizano.Controllers.Admins
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionLabelController : ControllerBase
    {
        private readonly IPermissionLabelService _permilabelService;
        public PermissionLabelController(IPermissionLabelService permilabelService)
        {
            _permilabelService = permilabelService;
        }

        // GET: api/<PermissionLabelController>
        [HttpGet]
        public async Task<IEnumerable<PermissionLabelDto>> Get()
        {
            return await _permilabelService.FindAllAsync();
        }


    }
}
