using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new CustomerCheckManager() );
            customerManager.Save(new Customer() { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Yunus", LastName = "Yılmaz", NationalityId =12345678901 } );


            
        }
    }
}
