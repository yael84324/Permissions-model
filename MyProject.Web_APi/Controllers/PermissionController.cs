using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;

namespace MyProject.Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : Controller
    {
        private readonly IPermissionService _permissionService;
        public PermissionController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        [HttpGet]   
        public List<PermissionDTO> GetAll()
        {
            return _permissionService.GetAll();
        }
        [HttpGet("{id}")]
        public PermissionDTO GetById(int id)
        {
            return _permissionService.GetById(id);
        }
        [HttpPost]
        public async Task<PermissionDTO> Add(int id,string name,string description)
        {
            return await _permissionService.AddAsync(id, name, description);
        }
        [HttpPut]
        public  async Task<PermissionDTO> Update(PermissionDTO permission)
        {
            return await _permissionService.UpdateAsync(permission);
        }
        [HttpDelete]
        public async Task Delete(int id)
        {
            await _permissionService.DeleteAsync(id);   
        }
    }
}
