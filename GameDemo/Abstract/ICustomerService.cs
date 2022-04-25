using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface ICustomerService
    {
        public void AddNewCustomer(Customer customer);
        public void RemoveCustomer(Customer customer);
        public void UpdateCustomer(Customer customer);
    }
}
