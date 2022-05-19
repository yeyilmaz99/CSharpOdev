using System;

namespace Delegates
{

    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;

            myDelegate -= customerManager.SendMessage;

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            myDelegate2("Hello");


            myDelegate();
        }


        public class CustomerManager
        {
            public void SendMessage()
            {
                Console.WriteLine("Hello!");
            }


            public void ShowAlert()
            {
                Console.WriteLine("Be Careful!");
            }


            public void SendMessage2(string message)
            {
                Console.WriteLine(message);
            }


            public void ShowAlert2(string alert)
            {
                Console.WriteLine(alert);
            }



        }
    }
}
