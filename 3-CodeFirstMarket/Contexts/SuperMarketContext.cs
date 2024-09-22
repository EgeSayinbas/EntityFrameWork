using _3_CodeFirstMarket.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirstMarket.Contexts
{
    public class SuperMarketContext:DbContext
    {

        public DbSet<Kategori> Kategoriler { get; set; } // Property'ye verilen isim Tablo ismi olarak database'e yansir
        public DbSet<Urun> Urunler { get; set; }

        // Burasi override edilmek durumundadir ki nereye bağlanacagini bilsin.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=SuperMarket;Trusted_Connection=true;TrustServerCertificate=true");
        }

    }
}
