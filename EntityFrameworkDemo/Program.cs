using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ADO.NET
            //Entity Framework -- ORM - Object relational mapping

            //GetAll();
            GetProductsByCategory(1);
        }

        private static void GetAll()
        {
            NorthwindContext context = new NorthwindContext();

            foreach (var product in context.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }


        private static void GetProductsByCategory(int categorId)
        {
            NorthwindContext northwindContext = new NorthwindContext();
            var result = northwindContext.Products.Where(p => p.CategoryId == categorId);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

        }
    }
}
