using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IClaimService
    {
        List<ClaimDTO> GetAll();

        ClaimDTO GetById(int id);

        Task<ClaimDTO> AddAsync(int id, int roleId, int permissionId, EPolicy policy);

        Task<ClaimDTO> UpdateAsync(ClaimDTO claim);

        Task DeleteAsync(int id);
    }
}
