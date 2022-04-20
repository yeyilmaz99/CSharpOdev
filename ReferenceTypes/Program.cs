using System;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// int,decimal,float,enum,boolean are value types
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;

            //sayi2 = 100;
            //Console.WriteLine(sayi1);
            //// result is 20 bc we only attach the values of variables on this types


            //// arrays,class,interface... are reference types


            //int[] nums1 = { 1, 2, 3, };
            //int[] nums2 = { 10,20,30 };

            //nums1 = nums2;

            //nums2[0] = 1000;

            //Console.WriteLine(nums1[0]);

            ////result is 1000 bc we attach the reference numbers



            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Engin";
            person2 = person1;

            person1.FirstName = "Yunus";
            Console.WriteLine(person2.FirstName);
            // Result is Yunus // we attach the reference numbers





            Customer customer = new Customer();
            customer.FirstName = "Yagmur";
            customer.CreditCardNumber = "1234567890";
            Employee employee = new Employee();
            employee.FirstName = "Emir";

            Person person3 = customer;
            Console.WriteLine(person3.FirstName);



            // Boxing
            Console.WriteLine(((Customer)person3).CreditCardNumber);


            PersonManager personManager = new PersonManager();

            personManager.Add(employee);


        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    //base class : Person
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
