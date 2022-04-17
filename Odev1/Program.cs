using System;
using System.Linq;


namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            //var result = Add2(2,5);
            //Console.WriteLine(result);  

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add4(ref number1, number2);
            //Console.WriteLine(number1);
            //Console.WriteLine(result2);
            Console.WriteLine(Multiply(2,5));
            Console.WriteLine(Multiply(2, 5,7));
            Console.WriteLine(Add5(2,4,5,6,7,8));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added");
        }
        static int Add2(int number1, int number2)
        {
            int result = number1+ number2;
            return result;
        }

        //eğer 2. değer verilmezse 30 verilirse verilen değer geçerli olur.
        static int Add3(int number1, int number2=30)
        {
            int result = number1 + number2;
            return result;
        }

        static int Add4(ref int number1, int number2)
        {
            //ref ya da out keyword ü ile fonksiyon içinde değişikliğe uğrayan değişkenin değeri değişiyor
            number1 = 30;
            return number1 + number2;
        }


        static int Multiply(int number1,int number2)
        {
            return number1 * number2;   
        }


        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add5(params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}
