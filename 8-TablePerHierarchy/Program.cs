using Microsoft.EntityFrameworkCore;

namespace _8_TablePerHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlDbcontext db = new SqlDbcontext();
            Otomobilllleerrsssss otomobil = new Otomobilllleerrsssss()
            {
                Marka = "BMW",
                KasaTipi = KasaTipi.Sedan,
                Model = "320"
            };
            Otobüüüğşçös otobus = new()
            {
                Marka = "Volvo",
                Model = "XYZ",
                KoltukSayisi = 48
            };

            db.Otobusler.Add(otobus);
            db.Otomobils.Add(otomobil);
            db.SaveChanges();
            //var bmw=db.Otomobils.Where(o => o.Marka=="BMW").FirstOrDefault();
            //var mercedes = db.Otobusler.Where(o => o.Marka == "Mercedes").FirstOrDefault();

            Console.WriteLine("Hello, World!");
        }
    }
   public class SqlDbcontext : DbContext
    {
        public DbSet<Arac> Araclar { get; set; }
        public DbSet<Otomobilllleerrsssss> Otomobils { get; set; }
        public DbSet<Otobüüüğşçös> Otobusler { get; set; }
        public DbSet<Kamyon> Kamyonlar { get; set; }
        public DbSet<Motorsiklet> Motorsikletler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=TablePerHiararchy;Trusted_Connection=true;TrustServerCertificate=true");

        }
    }

    public abstract class Arac
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }

    }

    public enum MotorsikletTipi
    {
        Scoter=1,
        Naked,
        Race
    }

    public class Motorsiklet : Arac
    {
        public MotorsikletTipi MotorsikletTipi { get; set; }
    }

    public class Kamyon : Arac
    {
        public int Kapasitesi { get; set; }
    }

    //public class Arac
    //{
    //    public int Id { get; set; }
    //    public string Marka { get; set; }
    //    public string Model { get; set; }

    //}
    public class Otomobilllleerrsssss : Arac
    {
       
        public KasaTipi KasaTipi { get; set; }
    }
    public class Otobüüüğşçös : Arac
    {
       
        public int KoltukSayisi { get; set; }
    }

    public enum KasaTipi:byte
    {

        Sedan=1,
        Cupe,
        StationWagon
    }
}
