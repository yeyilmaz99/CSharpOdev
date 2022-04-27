using GameDemoV2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemoV2.Concrete
{
    internal class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckCustomer(Customer customer)
        {
            return true;
        }
    }
}
