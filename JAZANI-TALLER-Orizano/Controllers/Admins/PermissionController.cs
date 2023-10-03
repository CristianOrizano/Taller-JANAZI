using Jazani.Taller.Aplication.Admins.Dtos;
using Jazani.Taller.Aplication.Admins.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JAZANI_TALLER_Orizano.Controllers.Admins
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService _permissioService;
        public PermissionController(IPermissionService permissiService)
        {
            _permissioService = permissiService;
        }


        // GET: api/<PermissionController>
        [HttpGet]
        public async Task<IEnumerable<PermissionDto>> Get()
        {
            return await _permissioService.FindAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<PermissionDto> Get(int id)
        {
            return await _permissioService.FindByIdAsync(id);
        }

        // POST api/<PermissionController>
        [HttpPost]
        public async Task<PermissionDto> Post([FromBody] PermissionSaveDto permiSaveDto)
        {
            return await _permissioService.CreateAsync(permiSaveDto);
        }

        // PUT api/<PermissionController>/5
        [HttpPut("{id}")]
        public async Task<PermissionDto> Put(int id, [FromBody] PermissionSaveDto permiSaveDto)
        {
            return await _permissioService.EditAsync(id, permiSaveDto);
        }

        // DELETE api/<PermissionController>/5
        [HttpDelete("{id}")]
        public async Task<PermissionDto> Delete(int id)
        {
            return await _permissioService.DisabledAsync(id);
        }
    }
}
