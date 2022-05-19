using System;

namespace _Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Topla(2,3));

            Func<int, int, int> add = Topla;

            Console.WriteLine(add(3,5));
        }

        public static int Topla(int x,int y)
        {
            return x + y;
        }
    }
}
