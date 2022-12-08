using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;

namespace MyProject.Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService; 
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        [HttpGet]
        public List<RoleDTO> GetAll()
        {
            return _roleService.GetAll();    
        }
        [HttpGet("{id}")]
        public RoleDTO GetById(int id)
        {
            return _roleService.GetById(id);
        }
        [HttpPost]
        public async Task<RoleDTO> Add(int id,string name,string description)
        {
            return await _roleService.AddAsync(id,name,description);   
        }
        [HttpPut]
        public async Task<RoleDTO> Update(RoleDTO role)
        {
            return await _roleService.UpdateAsync(role);
        }
        [HttpDelete]
        public async Task Delete(int id)
        {
            await _roleService.DeleteAsync(id); 
        }
    }
}
