using _5_IEntityTypeConfigurationsKullanimi.Entities.Concrete;
using _5_IEntityTypeConfigurationsKullanimi.EntityConfigs.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_IEntityTypeConfigurationsKullanimi.EntityConfigs.Concrete
{
    public class MusteriConfig:BaseConfig<Musteri>
    {
        public override void Configure(EntityTypeBuilder<Musteri> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.MusteriAdi).HasMaxLength(50);
            builder.Property(p => p.VergiNo).HasMaxLength(15);
            builder.Property(p => p.Email).HasMaxLength(50);
            builder.Property(p => p.Gsm).HasMaxLength(15);

            builder.HasIndex(p => p.VergiNo).IsUnique();


        }
    }
}
