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
    public class PermisionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository; 
        public PermisionService(IPermissionService permissionService)
        {
            _permissionRepository = permissionRepository;
        }

        public async Task<PermissionDTO> AddAsync(int id, string name, string description)
        {
            return await _permissionRepository.AddAsync(id, name, description);
        }

        public async Task DeleteAsync(int id)
        {
            await _permissionRepository.DeleteAsync(id);
        }

        public List<PermissionDTO> GetAll()
        {
            return _permissionRepository.GetAll(); 
        }

        public PermissionDTO GetById(int id)
        {
            return _permissionRepository.GetById(id);
        }

        public async Task<PermissionDTO> UpdateAsync(PermissionDTO permission)
        {
            return await _permissionRepository.UpdateAsync(permission);
        }
    }
}
