using Microsoft.EntityFrameworkCore;
using NorthwindEntities.SqlServerEntities;

namespace _2_ChangeTrackerKavrami
{
    #region Tanim
    //Context nesnesi üzerinden gelen tüm nesneler/veriler otomatik olarak bir takip mekanizması tarafından izlenirler.
    //İşte bu takip mekanizmasına Change Tracker denir.
    //Change Traker ile nesneler üzerindeki değişiklikler/işlemler takip edilerek netice itibariyle bu işlemlerin fıtratına uygun sql sorgucukları
    //generate edilir. İşte bu işleme de Change Tracking denir. 
    #endregion
    #region ChangeTracker Propertysi
    /*
     * Contect nesnesini bir property'sidir. Degisiklige ugrayan entities'lerin listesini verir
     * 
     */
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            SqlNorthwinContext context = new SqlNorthwinContext();
            Shipper shipper = new Shipper()
            {
                CompanyName = "Guzel Kargo",
                Phone = "123123"
            };
            Console.WriteLine(context.Entry(shipper).State);//Detached verecektir. Sebebi henuz Ef Core'a bildirmedim
            context.Shippers.Add(shipper); // Ekleme
            Console.WriteLine(context.Entry(shipper).State); //Added verecektir

            var result = context.Shippers.AsNoTracking().ToList(); // Burada gelen listedeki kayitlari Track etme yani izleme demek.
           


            var shipper12 = context.Shippers.Find(12);
            shipper12.CompanyName = "CVB KArgo";
            context.Shippers.Update(shipper12); // Guncelleme

            var shipper8 = context.Shippers.Find(8); //Silme
            context.Shippers.Remove(shipper8);


            foreach (var entry in context.ChangeTracker.Entries())
            {
                Console.WriteLine($"Entity: {entry.Entity.GetType().Name}, State: { entry.State.ToString()} ");
            }

            #region Entry Metodu
            //Entity nesnelerinin durumlarını ifade eder.
            context.Entry(shipper8).State = EntityState.Modified; // Manuel Mudahale edilmesi durumu
            Console.WriteLine("Shipper 8:"+context.Entry(shipper8).State);
            Console.WriteLine("New Shipper :" + context.Entry(shipper).State);
            Console.WriteLine("Shipper 12 :"+ context.Entry(shipper12).State);

            context.SaveChanges();

            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}
