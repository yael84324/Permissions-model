using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IPermissionRepository

    {
        List<Permission> GetAll();

        Permission GetById(int id);

        Permission Add(int id, string name, string description);

        Permission Update(Permission permission);

        Permission Delete(int id);

    }
}
