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
    public class RoleConfig:BaseConfig<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.RolName).HasMaxLength(50);

            builder.HasIndex(p => p.RolName).IsUnique();
        }
    }
}
