using Microsoft.AspNetCore.Mvc;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;

namespace MyProject.Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : Controller
    {
        private readonly IRoleRepository _roleRepository; 
        public RoleController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        [HttpGet]
        public List<Role> GetAll()
        {
            return _roleRepository.GetAll();    
        }
        [HttpGet("{id}")]
        public Role GetById(int id)
        {
            return _roleRepository.GetById(id);
        }
        [HttpPost]
        public async Task<Role> Add(int id,string name,string description)
        {
            return await _roleRepository.AddAsync(id,name,description);   
        }
        [HttpPut]
        public async Task<Role> Update(Role role)
        {
            return await _roleRepository.UpdateAsync(role);
        }
        [HttpDelete]
        public async Task Delete(int id)
        {
            await _roleRepository.DeleteAsync(id); 
        }
    }
}
