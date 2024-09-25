using Microsoft.EntityFrameworkCore;
using NorthwindEntities.SqlServerEntities;

namespace _9_EfCoreQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlNorthwinContext db = new SqlNorthwinContext();
            #region Almanyadaki musterilerin listesi

            //Metod Syntaxt
            //var musteriler = db.Customers.Where(p => p.Country == "Germany").ToList();
            //foreach (var item in musteriler)
            //{
            //    Console.WriteLine(item.CompanyName);
            //}
            ////Query Syntaxt
            //Console.WriteLine("******************************");
            //var musteriler2 = from customer in db.Customers
            //                  where customer.Country=="Germany"
            //                  select customer;
            //foreach (var item in musteriler2)
            //{
            //    Console.WriteLine(item.CompanyName);
            //}

            #region Sadece belirli kolonlari secmek isteseydik
            //Sadece belirli kolonlari secmek isteseydik
            // select customerId ,compnayname,city,country from customer 
            #region Metod Syntax
            //Metod Syntaxt
            //var musteriler = db.Customers.Where(p => p.Country == "Germany").Select(p=> new 
            //{ 
            //    MusteriId=p.CustomerId,
            //    SirketAdi=p.CompanyName,
            //    Sehir=p.City,
            //    Ulke=p.Country
            //}).ToList();
            //foreach (var item in musteriler)
            //{
            //    Console.WriteLine(item.SirketAdi +  " " + item.Sehir + " " + item.Ulke);
            //} 
            #endregion

            #region Query Syntax
            //var musteriler2 = from customer in db.Customers
            //                  where customer.Country == "Germany"
            //                  select new { 
            //                   customer.CustomerId,
            //                      customer.CompanyName,
            //                       customer.City,
            //                        customer.Country
            //                  };
            //foreach (var item in musteriler2)
            //{
            //    Console.WriteLine(item.CompanyName + " " + item.City + " " + item.Country);
            //}
            #endregion
            #endregion
            #endregion

            #region Urunler ve Kategorileri Listesi => productName,CategoryName,UnitPrice
            #region Metod
            //var urunler = db.Products.Include(p => p.Category).Include(p=>p.Supplier).ToList();
            //foreach (var item in urunler)
            //{
            //    Console.WriteLine(item.ProductName+" " + item.Category.CategoryName + " " + item.UnitPrice);
            //}
            #endregion
            #region Query

            //var urunler = from p in db.Products
            //              join c in db.Categories on p.CategoryId equals c.CategoryId
            //              join s in db.Suppliers on p.SupplierId equals s.SupplierId
            //              where c.CategoryId==1 
            //              select new
            //              {
            //                  Urun = p.ProductName,
            //                  Kategori = c.CategoryName,
            //                  Tedarikci = s.CompanyName,
            //                  Fiyat = p.UnitPrice
            //              };

            //foreach (var item in urunler)
            //{
            //    Console.WriteLine(item.Urun + " " + item.Kategori+ " " + item.Tedarikci );
            //}
            #endregion
            #endregion


            #region ThenInclude

            #region Metod Syntax
            //var siparisler = db.Orders.Include(p => p.OrderDetails)
            //                                    .ThenInclude(p => p.Product)
            //                              .Include(p => p.Customer)
            //                              .Include(p => p.Employee)
            //                              .Where(p => p.OrderDate.Value.Year == 1996 && p.OrderDate.Value.Month == 9)
            //                              .ToList();

            //decimal toplamtutar = 0;
            //foreach (var item in siparisler)
            //{
            //    Console.WriteLine(item.OrderId + " " + item.Customer.CompanyName + " " + item.Employee.FirstName + " " + item.Employee.LastName + " " + item.OrderDate);
            //    foreach (var detail in item.OrderDetails)
            //    {
            //        toplamtutar += detail.UnitPrice * detail.Quantity;
            //        Console.WriteLine("\t\t" + detail.Product.ProductName + " " + detail.Quantity + " " + detail.UnitPrice);
            //    }
            //    Console.WriteLine("\t\t" + " Siparis Toplami :" + toplamtutar);
            //} 
            #endregion
            #region Query Syntax

            //var siparisler = from o in db.Orders
            //                 join od in db.OrderDetails.Include(p=>p.Product) on o.OrderId equals od.OrderId
            //                 join p in db.Products on od.ProductId equals p.ProductId
            //                 join e in db.Employees on o.EmployeeId equals e.EmployeeId
            //                 join c in db.Customers on o.CustomerId equals c.CustomerId
            //                 where o.OrderDate.Value.Year == 1996 && o.OrderDate.Value.Month == 9
            //                 select new
            //                 {
            //                     OrderId = o.OrderId,
            //                     CompanyName = c.CompanyName,
            //                     Employee = e,
            //                     OrderDate = o.OrderDate,
            //                     OrderDetail = od,
            //                     Customer = c
            //                 };

            //var siparisler = (from od in db.OrderDetails
            //                 join p in db.Products on od.ProductId equals p.ProductId
            //                 join o in db.Orders on od.OrderId equals o.OrderId
            //                 join c in db.Customers on o.CustomerId equals c.CustomerId
            //                 join e in db.Employees on o.EmployeeId equals e.EmployeeId
            //                 select new
            //                 {
            //                     OrderDetail = od,

            //                 }).ToList();


            //decimal toplamtutar = 0;
            //foreach (var item in siparisler)
            //{

            //    //Console.WriteLine(item.OrderId + " " + item.Customer.CompanyName + " " + item.Employee.FirstName + " " + item.Employee.LastName + " " + item.OrderDate);
            //    //foreach (var detail in item.OrderDetail)
            //    //{
            //    //    toplamtutar += detail.UnitPrice * detail.Quantity;
            //    //    Console.WriteLine("\t\t" + detail.Product.ProductName + " " + detail.Quantity + " " + detail.UnitPrice);
            //    //}
            //    Console.WriteLine("\t\t" + " Siparis Toplami :" + toplamtutar);
            //}
            #endregion
            #endregion

            #region Gruplama
            /*
             * select country,count(*)
             * from Customers 
             * group by country
             * order by country
             * 
             * 
             */

            #region Metod Syntax 

            var result = db.Customers.GroupBy(p => p.Country).Select(p=> new
            {
               name = p.Key,
               adet=p.Count()
            }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.name + " " + item.adet);
            }

            #endregion
            #region Query

            //var result = from c in db.Customers
            //             group c by c.Country into g
            //             select new
            //             {
            //                 name=g.Key,
            //                 adet=g.Count()
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.name + " " + item.adet);
            //}
            #endregion

            #endregion

            Console.WriteLine("Hello, World!");
        }
    }
}

