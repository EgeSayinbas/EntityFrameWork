using _5_IEntityTypeConfigurationsKullanimi.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_IEntityTypeConfigurationsKullanimi.EntityConfigs.Abstract
{
    public abstract class BaseConfig<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
           builder.HasKey(x => x.Id);
           
        }
    }
}
