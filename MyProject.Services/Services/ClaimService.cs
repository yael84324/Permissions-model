using MyProject.Common.DTOs;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class ClaimService : IClaimService
    {
        private readonly IClaimRepository _claimRepository;
        public ClaimRepository(IClaiRepository claimRepository)
        {
            _claimRepository = claimRepository;
        }

        public async Task<ClaimDTO> AddAsync(int id, int roleId, int permissionId, EPolicy policy)
        {
            return await _claimRepository.AddAsync(id, roleId, permissionId, policy);
        }

        public async Task DeleteAsync(int id)
        {
            await _claimRepository.DeleteAsync(id);
        }

        public List<ClaimDTO> GetAll()
        {
            return _claimRepository.GetAll();
        }

        public ClaimDTO GetById(int id)
        {
            return _claimRepository.GetById(id);
        }

        public async Task<ClaimDTO> UpdateAsync(ClaimDTO claim)
        {
            return await _claimRepository.UpdateAsync(claim); 
        }
    }
}
