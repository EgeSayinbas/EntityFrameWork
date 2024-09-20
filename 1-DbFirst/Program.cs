using _1_DbFirst.Entities;
using _1_DbFirst.NorthwinSiparisler;

namespace _1_DbFirst
{
    internal class Program
    {
        #region Gerekli ortamin hazirlanmasi benim

        /*
         * 1- EntityFramework tool un u kurmak
         * bunu komut satiri uzerinden yapicaz (terminal) dotnet tool install --global dotnet-ef    ef tool paketini yukler
         * 
         * ayrica projemize hangi databese ile calisacaksak mesela EntityFrameWorkCore.SqlServer ilgili paketini
         * ve EntityFrameWork.Design paketini kurmak gereklidir
         * bu paketleri nuget uzerinden indirebiliriz
         * 
         * 
         * halihazirdaki bir databese in DbContext ini cikarmak icin asagidaki komut kullanilabilir
         * 
         * burada connection string ve hangi databsase paketini kullanacağınızı degistirmek yeterli olacaktir
         * dotnet ef dbcontext scaffold "server=.;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=true" Microsoft.EntityFrameWorkCore.SqlServer -o Entities
         * 
         * 
         * postgre
         * dotnet ef dbcontext scaffold "server=127.0.0.1;Database=Northwind;User Id=postgres;password=qweasd" Npgsql.EntityFrameWorkCore.PostgreSQL -o PostgreNorthwind
         * 
         * mysql
         * dotnet ef dbcontext scaffold "server=127.0.0.1;Database=sakila;UId=root;pwd=qweasd" MySql.EntityFrameWorkCore -o MySakila

         * 
         * 
         */
        #endregion
        #region Gerekli oramin hazilanmasi
        /*
         * 1- EntityFramework tool 'unu kurmak
         * Bunu komut satiri uzerinden yapacagiz
         * 
         *  dotnet tool install --global dotnet-ef komutu ef tool paketini kurar
         *  
         *  Ayrica projemize hangi database ile calisacak isek 
         *  Mesela EntityFrameWorkCore.SqlServer ilgili paketini ve EntityFrameWorkCore.Design paketini kurmak gereklidir.
         *  Bu paketleri nuget uzerinden indirebiliriz
         *  
         *  Halihazirdaki bir database'in DbContext'ini cikartmak icin aşagidaki komut kullanilabilir.
         *  Burada Connection string ve Hangi database paketi ni kullanacagimiz degistirmek yeterli olacaktir.
         *  
         *  dotnet ef dbcontext scaffold 
         *  "server=.;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=true"  //Burasi Connection string bolumu
         *  Microsoft.EntityFrameWorkCore.SqlServer    // Hangi databasea ile calisacagi bilgisi
         *  -o Entities  // output olarak hangi Klasore cikti verecegi
         */
        #endregion
        static void Main(string[] args)
        {
            Entities.Shipper shipper = new Entities.Shipper()
            {
                ShipperId = 11,
                CompanyName =null,
                Phone = "123123"
            };
            NorthwindContext context = new NorthwindContext();
            //NorthwindSiparis siparisContext = new NorthwindSiparis();
            
            // context.Customers.Where(p => p.Country == "UK").ToList().ForEach(p => Console.WriteLine(p.CompanyName + " " + p.Country));
            
            //Update
            //var shipper11 = context.Find<Shipper>(11);
            //shipper11.CompanyName = "Deneme";
            //context.Shippers.Update(shipper11);
            //Insert
            //context.Shippers.Add(shipper);
            
            context.Shippers.Update(shipper);
          
            context.SaveChanges();
            Console.WriteLine("Hello, World!");
        }
    }
}
