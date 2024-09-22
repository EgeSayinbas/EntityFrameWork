using _4_FluentApiKullanimi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_FluentApiKullanimi.Contexts
{
    public class SuperMarketContextPostgres:DbContext
    {

        public DbSet<Kategori> Kategoriler { get; set; } // Property'ye verilen isim Tablo ismi olarak database'e yansir
        public DbSet<Urun> Urunler { get; set; }

        // Burasi override edilmek durumundadir ki nereye bağlanacagini bilsin.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server=127.0.0.1;Database=SuperMarketYeni;User Id=postgres;password=qweasd");
        }


        /*
         * OnModelCreating metodu bize kullandigimiz entitiy'leri configure etmemize olanak saglar
         * 
         * Bunun icin fluent api kullanilir
         * 
         */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Kategory prop'larinin configurasyonu
            modelBuilder.Entity<Kategori>().Property(p => p.KategoriAdi).HasMaxLength(50);
            modelBuilder.Entity<Kategori>().Property(p => p.Aciklama).HasMaxLength(1000);
            modelBuilder.Entity<Kategori>().HasKey(p => p.Id); //Primary Key yapar

            modelBuilder.Entity<Kategori>().HasIndex(p => p.KategoriAdi).IsUnique(); // Unique index atar 
           
            
            modelBuilder.Entity<Kategori>().HasMany(kategori => kategori.Urunler)
                                            .WithOne(urun => urun.Kategori)
                                                .HasForeignKey(urun => urun.KategoriId)
                                                    .OnDelete(DeleteBehavior.NoAction);
            #endregion


            #region Product Tablosunun configuration 
            modelBuilder.Entity<Urun>().HasKey(p => p.UrunID);
            modelBuilder.Entity<Urun>().Property(p => p.UrunAdi).HasMaxLength(50);
            modelBuilder.Entity<Urun>().Property(p => p.UrunKodu).HasMaxLength(100);
            modelBuilder.Entity<Urun>().HasIndex(p => p.UrunKodu).IsUnique();

            modelBuilder.Entity<Urun>()
                        .HasOne(p => p.Kategori)
                        .WithMany(p => p.Urunler)
                        .HasForeignKey(p=>p.KategoriId)
                        .OnDelete(DeleteBehavior.NoAction);
            #endregion


        }

    }
}
