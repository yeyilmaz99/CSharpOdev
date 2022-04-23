using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PersonManager personManager = new PersonManager();
            //Customer customer = new Customer() { Id = 1, FirstName = "Yunus", Address = "Eskişehir", LastName = "Yılmaz" };
            //personManager.Add(customer);
            //Student student = new Student();
            //student.Id = 1;
            //student.FirstName = "Yagmur";
            //student.LastName = "Şahin";
            //student.Department = "French";

            //personManager.Add(student);


            //CustomerManager customerManager = new CustomerManager();

            //customerManager.Add(new SqlServerCustomerDal());
            //customerManager.Add(new OracleCustomerDal());


            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (ICustomerDal customerDal in customerDals)
            {
                customerDal.Add();
            }








            Console.ReadLine();
        }
    }

}
