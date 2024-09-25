using _6_ManyToMany.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _6_ManyToMany.Contexts
{
    public class MyWebSiteContext : DbContext
    {
        public DbSet<Role> Roller { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=MyWebSite;Trusted_Connection=true;TrustServerCertificate=true");
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
