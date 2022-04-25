using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    internal class BaseCustomerManager : ICustomerService
    {
        public virtual void AddNewCustomer(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " User Added");
        }

        public void RemoveCustomer(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " User Deleted");
        }

        public void UpdateCustomer(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " User Updated");
        }
    }
}
