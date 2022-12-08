using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class PermissionRepository:IPermissionRepository
    {
        private readonly IContext _context;

        public PermissionRepository(IContext context)
        {
            _context = context;
        }
        public Permission Add(int id, string name, string description)
        {

            _context.Permissions.Add(new Permission { Id = id, Name = name, Description = description });
            return _context.Permissions.First(p => p.Id == id);
        }

        public Permission Delete(int id)
        {
            Permission r = _context.Permissions.First(p1 => p1.Id == id);
            _context.Permissions = _context.Permissions.Where(p1 => p1.Id != id).ToList();
            return r;
        }

        public List<Permission> GetAll()
        {
            return _context.Permissions;
        }

        public Permission GetById(int id)
        {
            return _context.Permissions.First(p => p.Id == id);
        }

        public Permission Update(Permission permission)
        {
            Permission r = _context.Permissions.First(p => p.Id == permission.Id);
            r.Name = permission.Name;
            r.Description = permission.Description;
            return r;
        }
    }
}
