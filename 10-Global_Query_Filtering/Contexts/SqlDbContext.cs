using _10_Global_Query_Filtering.Entites.Abstract;
using _10_Global_Query_Filtering.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _10_Global_Query_Filtering.Contexts
{
    public class SqlDbContext:DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.;Database=GlobalFiltering;Trusted_Connection=True;TrustServerCertificate=true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override int SaveChanges()
        {
            //dbcontext icerisindeki silinmis olnalarin listesini aliyoruz
            var deleted = this.ChangeTracker.Entries()
                            .Where(p => p.State == EntityState.Deleted)
                            .Select(t=>t.Entity)
                            .ToList();
            foreach (var item in deleted)
            {
                var silinen = item as BaseEntity;
                silinen.IsDelete = true;
                this.Entry<BaseEntity>(silinen).State = EntityState.Modified; // Update olarak isaretle ki silinmesin.
            }

            var added = this.ChangeTracker.Entries()
                          .Where(p => p.State == EntityState.Added)
                          .Select(t => t.Entity)
                          .ToList();


            foreach (var item in added)
            {
                if (item is Person)
                {
                    (item as Person).Menuler.Add(new() { MenuAdi="File",CreateDate=DateTime.Now});
                    (item as Person).Menuler.Add(new() { MenuAdi = "Cari", CreateDate = DateTime.Now });
                    (item as Person).Menuler.Add(new() { MenuAdi = "Stok", CreateDate = DateTime.Now });
                }
                
            }




            return base.SaveChanges();
        }
    }
}
