using _6_ManyToMany.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ManyToMany.Entities.Concrete
{
    public class User:BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public string? Email { get; set; }
        public string? Gsm { get; set; }
        public ICollection<Role>? Roles { get; set; }
    }
}
