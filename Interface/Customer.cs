using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Customer : IPerson
    {
        public string LastName { get ; set ; }
        public int Id { get ; set ; }
        public string FirstName { get  ; set  ; }
        public string Address { get; set; }
    }
}
