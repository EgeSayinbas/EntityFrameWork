using _11_GenericRepository.Concrete;
using NorthwindEntities.SqlServerEntities;
using System.Globalization;

namespace _11_GenericRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Customer> customerRepo = new Repository<Customer>();
            //var cust1 = customerRepo.GetById("ALFKI123");
            //var customers = customerRepo.GetAll();
            // Console.WriteLine(cust1.CustomerId +    " " + cust1.CompanyName);

            //var cust2 = customerRepo.GetBy(p => p.Country == "UK" && p.City == "London");

            #region Generic Repository'ye nasil predicate delegate gecebilirim. Yada Func<T,bool> Func delegate nasil gecerim
            // customerRepo.GetAll(p => p.Country == "UK" && p.City == "London").ForEach(p=> Console.WriteLine(p.CompanyName+ " " + p.City));

            #endregion

            #region Iliskili kayitlarin getirilmesi
            //Repository<Product> productRepo = new Repository<Product>();
            //var result = productRepo.GetAllInclude(p=>p.CategoryId == 1,p=>p.Supplier,p=>p.Category,p=>p.OrderDetails).ToList();

            #endregion

            #region İş Kurallarinin oldugu ayri bir repository kullanimi

            var hindiCulture = new CultureInfo("hi-IN");
            Console.WriteLine(hindiCulture.EnglishName);
            Console.WriteLine(hindiCulture.NativeName);


            CustomerRepository dbCustomer = new CustomerRepository();
            Customer cust1 = new Customer { CompanyName = "ABC LTD", CustomerId = "ABCDE", Country = "ISrail" };
            dbCustomer.Insert(cust1);
            #endregion

            Console.WriteLine("");

        }
    }
}
