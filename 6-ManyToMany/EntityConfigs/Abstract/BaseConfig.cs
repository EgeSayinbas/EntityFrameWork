using _6_ManyToMany.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ManyToMany.EntityConfigs.Abstract
{
    public class BaseConfig<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
