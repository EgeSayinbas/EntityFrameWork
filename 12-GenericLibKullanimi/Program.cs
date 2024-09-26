using GenericReposLib.Concrete;
using NorthwindEntities.SqlServerEntities;

namespace _12_GenericLibKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Product, SqlNorthwinContext> productRepository = new Repository<Product, SqlNorthwinContext>();

            var result = productRepository
                    .GetAllInclude(p => p.CategoryId == 2, p => p.Supplier, p => p.Category, p => p.OrderDetails)
                    .ToList();
            Console.WriteLine("Hello, World!");
        }
    }
}
