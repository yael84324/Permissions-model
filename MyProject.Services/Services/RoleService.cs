using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Common.DTOs;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
namespace MyProject.Services.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleService roleService)
        {
            _roleRepository = roleRepository;
        }

        public async Task<RoleDTO> AddAsync(int id, string name, string description)
        {
            return await _roleRepository.AddAsync(id, name, description);   
        }

        public async Task DeleteAsync(int id)
        {
            await _roleRepository.DeleteAsync(id);
        }

        public List<RoleDTO> GetAll()
        {
            return _roleRepository.GetAll();
        }

        public RoleDTO GetById(int id)
        {
            return _roleRepository.GetById(id);
        }

        public async Task<RoleDTO> UpdateAsync(RoleDTO role)
        {
            return await _roleRepository.UpdateAsync(role);
        }
    }
}
