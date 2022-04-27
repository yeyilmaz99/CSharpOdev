﻿using GameDemoV2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemoV2.Concrete
{
    internal class CustomerManager:BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public CustomerManager(CustomerCheckManager customerCheckManager)
        {
            _customerCheckService = customerCheckManager;
        }

        public override void Add(Customer customer)
        {
            if (_customerCheckService.CheckCustomer(customer))
            {
                base.Add(customer);
            }
            else
            {
                throw new Exception("User is not added");
            }

        }
    }
}
