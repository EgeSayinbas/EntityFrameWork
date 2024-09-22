using _3_CodeFirstMarket.Contexts;
using _3_CodeFirstMarket.Models;
using Microsoft.EntityFrameworkCore;

namespace _3_CodeFirstMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SuperMarketContext context = new SuperMarketContext();
            //Urun urun = new Urun();
            //var kategori = context.Kategoriler.Include(p=>p.Urunler).FirstOrDefault();

            //var urun1 = context.Urunler.FirstOrDefault();

            //Console.WriteLine("Adet Fiyat " + urun.Adet + " " + urun.Fiyat);

            #region Context'e ilikili kayit Atilmasi
            //Kategori kategori = new Kategori()
            //{
            //    KategoriAdi = "Testil",
            //    Aciklama = "Testil"
            //};
            //var urun1 = new Urun { UrunAdi = "Iphone" };
            //context.Urunler.Add(urun1);

            //var urun2 = new Urun { UrunAdi = "Asus Notebook" };
            //context.Urunler.Add(urun2);
            //var urun3 = new Urun { UrunAdi = "Samsung SSD Disk" };
            //context.Urunler.Add(urun3);

            //kategori.Urunler = new List<Urun>();
            //kategori.Urunler.Add(urun1);
            //kategori.Urunler.Add(urun2);
            //kategori.Urunler.Add(urun3);

            //context.Kategoriler.Add(kategori);



            context.SaveChanges();

            #endregion            Console.WriteLine("Hello, World!");
        }
    }
}
