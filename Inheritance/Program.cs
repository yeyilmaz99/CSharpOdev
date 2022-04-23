using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person[] persons = new Person[3]
            {
                new Person() { FirstName = "Yunus" },
                new Customer() { FirstName ="Yagmur"},
                new Student() {FirstName ="Emir"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();

        }
    }


    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    class Customer : Person // sadece bir inheritance kullanılabilir
    {
        public string City { get; set; } 
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
