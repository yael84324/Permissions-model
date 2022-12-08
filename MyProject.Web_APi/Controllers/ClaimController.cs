using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;

namespace MyProject.Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : Controller
    {
        private readonly IClaimService _claimService;
        public ClaimController(IClaimService claimService)
        {
            _claimService = claimService;
        }
        [HttpGet]
        public List<ClaimDTO> GetAll()
        {
            return _claimService.GetAll();
        }
        [HttpGet("{id}")]
        public ClaimDTO GetById(int id)
        {
            return _claimService.GetById(id);
        }
        [HttpPost]
        public async Task<ClaimDTO> Add(int id, int roleId, int prermissionId, EPolicy policy)
        {
            return await _claimService.AddAsync(id,roleId,prermissionId,policy);    
        }
        [HttpPut]
        public async Task<ClaimDTO> Update(ClaimDTO claim)
        {
            return await _claimService.UpdateAsync(claim);
        }
        [HttpDelete]
        public async Task Delete(int id)
        {
            await _claimService.DeleteAsync(id);
        }

    }
}
