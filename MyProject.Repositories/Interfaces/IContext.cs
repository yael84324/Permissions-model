using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IContext
    {
        public List<Role> Roles { get; set; }

        public List<Permission> Permissions{ get; set; }

        public List<Claim> Claims { get; set; }
        Task<int> SaveChangesAsync();
    }
}
