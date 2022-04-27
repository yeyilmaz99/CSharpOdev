using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemoV2.Abstract
{
    internal interface ICustomerCheckService
    {
        public bool CheckCustomer(Customer customer);
    }
}
