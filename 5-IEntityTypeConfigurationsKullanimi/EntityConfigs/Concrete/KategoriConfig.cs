using _5_IEntityTypeConfigurationsKullanimi.Entity.Concrete;
using _5_IEntityTypeConfigurationsKullanimi.EntityConfigs.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_IEntityTypeConfigurationsKullanimi.EntityConfigs.Concrete
{
    public class KategoriConfig:BaseConfig<Kategori>

    {
        public override void Configure(EntityTypeBuilder<Kategori> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.KategoriAdi).HasMaxLength(50);
            builder.HasIndex(p => p.KategoriAdi).IsUnique();
            builder.Property(p => p.Aciklama).HasMaxLength(500);

            //database olustururken bazi veriler atalim
            builder.HasData(new Kategori { Id=1,KategoriAdi="Elektronik",CreateDate=DateTime.Now, Aciklama = "Elektronik" },
                new Kategori { Id=2, KategoriAdi = "Gida", CreateDate = DateTime.Now,Aciklama= "Gida" },
                new Kategori { Id = 3, KategoriAdi = "Tekstil", CreateDate = DateTime.Now,Aciklama = "Tekstil" },
                new Kategori { Id = 4, KategoriAdi = "Kitap", CreateDate = DateTime.Now,Aciklama = "Kitap" },
                new Kategori { Id = 5, KategoriAdi = "Hirdavat", CreateDate = DateTime.Now, Aciklama = "Hirdavat" }
                );


        }
    }
}
