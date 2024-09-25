using _5_IEntityTypeConfigurationsKullanimi.Entities.Concrete;
using _5_IEntityTypeConfigurationsKullanimi.EntityConfigs.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _5_IEntityTypeConfigurationsKullanimi.Contexts
{
    public class TicariSqlContext : DbContext
    {
        public DbSet<Kategori>   Kategoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }

        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=KahramanBakkal;Trusted_Connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new KategoriConfig());
            //modelBuilder.ApplyConfiguration(new MusteriConfig());
            //modelBuilder.ApplyConfiguration(new UrunConfig());



            //Bu çaliştigi assembly iceridindeki butun IEntityTypeConfiguration 'dan inherit almiş ne kadar
            //class'varsa icerisindeki configure metodunu çaliştirir.

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            //Eger Config dosyalari başka bir projede ise asağidaki gibi load edilebilir
           // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.LoadFrom("NorthwindEntities"));
        }
    }
}
