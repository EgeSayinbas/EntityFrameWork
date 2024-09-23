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
            //modelBuilder.Entity<Kategori>();
            //modelBuilder.Entity<Urun>();
            //modelBuilder.Entity<Musteri>();

            //assembly icerisindeki butun IEntityTypeConfiguration dan inherit almis ne kadar
            //class varsa icersisinde configure metodu calistirilir
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //Eger config dosyalari baska bir projede ise asagidaki gibi load edilebilir
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.LoadFrom("NorthwindEntities"));
        }
    }
}
