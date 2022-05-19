using System;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2,3);

            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(5, 3));


            var type = typeof(DortIslem);

            var dortIslem = Activator.CreateInstance(type);







            
        }
    }

    public class DortIslem
    {


        int _sayi1, _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }





    }
}
