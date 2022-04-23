using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Customer
    {
        ////field
        //public string FirstName;


        //property
        public int Id { get; set; }
        private string _firstName;
        public string FirstName
        {
            get
            {
                return "Mr." + _firstName;   
            }
            
            set
            {
                _firstName = value;
            }
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
