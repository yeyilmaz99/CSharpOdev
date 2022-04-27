using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemoV2
{
    abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Add(Customer customer)
        {
            Console.WriteLine("Customer added");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer Updated");
        }
    }
}
