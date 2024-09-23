using _6_ManyToMany.Entities.Concrete;
using _6_ManyToMany.EntityConfigs.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ManyToMany.EntityConfigs.Concrete
{
    internal class RoleConfig : BaseConfig<Role>
    {
        public virtual void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }
}
