using Microsoft.AspNetCore.Mvc;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;

namespace MyProject.Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : Controller
    {
        private readonly IPermissionRepository _permissionRepository;
        public PermissionController(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }
        [HttpGet]   
        public List<Permission> GetAll()
        {
            return _permissionRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Permission GetById(int id)
        {
            return _permissionRepository.GetById(id);
        }
        [HttpPost]
        public Permission Add(int id,string name,string description)
        {
            return _permissionRepository.Add(id, name, description);
        }
        [HttpPut]
        public Permission Update(Permission permission)
        {
            return _permissionRepository.Update(permission);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _permissionRepository.Delete(id);   
        }
    }
}
