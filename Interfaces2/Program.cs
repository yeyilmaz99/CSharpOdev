using System;

namespace Interfaces2
{
    internal class Program
    {
        // interfaceler new'lenemez 
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();
            IPersonManager internManager = new InternManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            projectManager.Add(employeeManager);
            projectManager.Add(internManager);

        }
    }
    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();

    }

    //inherits - class ///////////// impelements - interface

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //customer adding codes
            Console.WriteLine("Customer Added");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            // Employee adding codes
            Console.WriteLine("Employee Added");
        }

        public void Update()
        {
            Console.WriteLine("Employee Updated");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern Added");
        }

        public void Update()
        {
            Console.WriteLine("Intern Updated");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager manager)
        {
            manager.Add();
        }
    }
}
