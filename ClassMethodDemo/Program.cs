using System;

namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Customer[] customers = new Customer[] 
            {
                new Customer() { Name = "Yunus", Age = 22, Id = 1 },
                new Customer() { Name = "Yagmur", Age = 20, Id = 2 },
                new Customer() { Name = "Emir", Age = 20, Id = 3 }
            };

            customerManager.AddCustomer(customers[0]);
            customerManager.DeleteCustomer(customers[1]);


            Customer customer1 = new Customer() { Name = "Yunus", Id = 1, Age = 22 };
            Customer customer2 = new Customer() { Name = "Yagmur", Id = 2, Age = 20 };
            Customer customer3 = new Customer() { Name = "Emir", Id = 3, Age = 20 };

            Customer[] customers2 = new Customer[] { customer1, customer2, customer3 };


            customerManager.AddCustomer(customer1);
            Console.WriteLine("---------------------------");

            customerManager.DeleteCustomer(customer2);
            Console.WriteLine("---------------------------");

            customerManager.ListCustomers(customers);

            Console.WriteLine("---------------------------");

            customerManager.ListCustomers(customers2);



        }
    }
}
