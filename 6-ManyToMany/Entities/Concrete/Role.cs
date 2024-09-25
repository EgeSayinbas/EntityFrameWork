using _6_ManyToMany.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ManyToMany.Entities.Concrete
{
    public class Role:BaseEntity
    {
        public string RolName { get; set; }

        public ICollection<User>? Users { get; set; }
    }
}
