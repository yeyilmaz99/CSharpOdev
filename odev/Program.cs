using System;

namespace odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "product1name";
            product1.Price = 222.58;
            product1.Favs = 500;

            Product product2 = new Product();
            product2.Name = "product2name";
            product2.Price = 222.58;
            product2.Favs = 500;

            Product product3 = new Product();
            product3.Name = "product3name";
            product3.Price = 222.58;
            product3.Favs = 500;


            Product[] products = new Product[] { product1, product2, product3 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name+ " adındaki ürün " + product.Price + " fiyatındadır "+ product.Favs +" favorisi vardır");
            }

            Console.WriteLine("*******************");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Name + " adındaki ürün " + products[i].Price + " fiyatındadır " + products[i].Favs + " favorisi vardır");
            }


            Console.WriteLine("*******************");

            int sayi = 0;

            while (sayi < products.Length)
            {
                Console.WriteLine(products[sayi].Name + " adındaki ürün " + products[sayi].Price + " fiyatındadır " + products[sayi].Favs + " favorisi vardır");
                sayi++;
            }


        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }   
        public int Favs { get; set; }   
    }
}
