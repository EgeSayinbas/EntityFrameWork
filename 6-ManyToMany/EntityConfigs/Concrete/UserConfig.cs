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
    internal class UserConfig : BaseConfig<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.UserName).HasMaxLength(128);
            builder.Property(p => p.Password).HasMaxLength(500);
            builder.Property(p => p.Gsm).HasMaxLength(15);
            builder.Property(p => p.Email).HasMaxLength(50);

            builder.HasIndex(p => p.UserName).IsUnique();
            builder.HasIndex(p => p.Email).IsUnique();
            builder.HasIndex(p => p.Gsm).IsUnique();

            //builder.HasData(new User { Id = 1, UserName = "Admin", Password = "qweasd", Gsm = "123123", Email = "admin@gmail.com", CreateDate = DateTime.Now });

        }
    }
}
