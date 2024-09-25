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
    public class UrunConfig:BaseConfig<Urun>
    {
        public override void Configure(EntityTypeBuilder<Urun> builder)
        {
            base.Configure(builder); // Bu kodu silmeyin. Cunku base deki abstract class configure edilecek
            builder.Property(p => p.UrunKodu).HasMaxLength(50);
            builder.Property(p => p.UrunAdi).HasMaxLength(100);
            builder.HasIndex(p => p.UrunKodu).IsUnique();


        }
    }
}
