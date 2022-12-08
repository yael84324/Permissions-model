using MyProject.Repositories.Entities;
using System.Xml.Linq;
using tray.first.Interface;

namespace MyProject.Mock
{
    public class MockContext : IContext
    {
        public List<Role> Roles { get; set; }
        public List<Permission> Permissions { get; set ; }
        public List<Claim> Claims { get ; set ; }
        private int saveIndex;
        public async Task<int> SaveChangesAsync()
        {
            return await Task.Run(() => GetSaveIndex());
        }
        private int GetSaveIndex() { return saveIndex++; }
        public MockContext()
        {
            Roles = new List<Role>() { new Role { Id = 1, Name = "admin", Description = "full access" }, 
                                       new Role { Id = 2, Name = "student", Description = "limited access" } };
            Permissions = new List<Permission>() { new Permission { Id = 1, Name = "viewAllTests", Description = "admin" },
                                                   new Permission { Id = 2, Name = "viewSomeTests", Description = "limited" } };
            Claims = new List<Claim>() { new Claim { Id = 2, RoleId = 2, PermissionId = 1, Policy = EPolicy.Deny } ,
                                         new Claim { Id = 1, RoleId = 1, PermissionId = 1, Policy = EPolicy.Allow }};
            

        }
    }
}