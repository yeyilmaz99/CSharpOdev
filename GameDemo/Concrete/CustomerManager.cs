using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    internal class CustomerManager: BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void AddNewCustomer(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.AddNewCustomer(customer);
            }
            else
            {
                throw new Exception("User is not valid");
            }

        }


    }
}
