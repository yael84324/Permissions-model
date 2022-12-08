using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyProject.Repositories.Repositories
{
    public class ClaimRepository:IClaimRepository
    {
        private readonly IContext _context;

        public ClaimRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Claim> AddAsync(int id, int roleId, int prermissionId, EPolicy policy)
        {
            _context.Claims.Add(new Claim() { Id=id,RoleId=roleId,PermissionId=prermissionId,Policy=policy});
            await _context.SaveChangesAsync();
            return GetById(id);
            
        }

        public async Task DeleteAsync(int id)
        {
           Claim claim=GetById(id);
            _context.Claims.Remove(claim);
            await _context.SaveChangesAsync();
        }

        public List<Claim> GetAll()
        {
            return _context.Claims;
        }

        public Claim GetById(int id)
        {
            return _context.Claims.First(x => x.Id==id);
        }

        public async Task<Claim> UpdateAsync(Claim claim)
        {
            _context.Claims[_context.Claims.IndexOf(_context.Claims.First(x => x.Id == claim.Id))] = claim;
            await _context.SaveChangesAsync();
            return claim;
        }
    }
}
