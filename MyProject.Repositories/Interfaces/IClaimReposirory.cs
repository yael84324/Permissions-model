using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Claim = MyProject.Repositories.Entities.Claim;

namespace MyProject.Repositories.Interfaces
{
    public interface IClaimRepository

    {
        List<Claim> GetAll();

        Claim GetById(int id);

        Task<Claim> AddAsync(int id, int roleId, int permissionId, EPolicy policy);

        Task<Claim> UpdateAsync(Claim claim);

        Task DeleteAsync(int id);

    }
}
