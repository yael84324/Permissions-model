using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public class Permission
    {
        public int Id { get; set; }

        public string Name { get; set; } // VIEW_ALL_ORDERS

        public string Description { get; set; }
    }
}
