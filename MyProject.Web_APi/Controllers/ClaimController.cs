using Microsoft.AspNetCore.Mvc;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Entities;
namespace MyProject.Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : Controller
    {
        private readonly IClaimRepository _claimRepository;
        public ClaimController(IClaimRepository claimRepository)
        {
            _claimRepository = claimRepository;
        }
        [HttpGet]
        public List<Claim> GetAll()
        {
            return _claimRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Claim GetById(int id)
        {
            return _claimRepository.GetById(id);
        }
        [HttpPost]
        public async Task<Claim> Add(int id, int roleId, int prermissionId, EPolicy policy)
        {
            return _claimRepository.Add(id, roleId, prermissionId, policy);    
        }
        [HttpPut]
        public Claim Update(Claim claim)
        {
            return _claimRepository.Update(claim);
        }
        [HttpDelete]
        public Claim Delete(int id)
        {
            return _claimRepository.Delete(id);
        }

    }
}
