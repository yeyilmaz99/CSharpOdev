using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() {Id =1, City = "eskişehir", FirstName = "Yunus Emre", LastName ="Yılmaz" };

            Console.WriteLine(customer.FirstName);
        }
    }
}
