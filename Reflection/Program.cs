using System;
using System.Reflection;

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

            DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,6,7);

            //Console.WriteLine(dortIslem.Topla(2, 5));
            //Console.WriteLine(dortIslem.Topla2());


            var instance = Activator.CreateInstance(type, 6,7);


            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

            
            Console.WriteLine(methodInfo.Invoke(instance, null));


            Console.WriteLine("************");
            var methodlar = type.GetMethods();

            foreach (var info in methodlar)
            {
                Console.WriteLine("Methodadı : {0}",info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0} " , parameterInfo.Name);
                }
                foreach(var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}", attribute.GetType().Name);
                }

            }

            Console.ReadLine();







            
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
        public DortIslem()
        {

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
        [MethodName("carbmaMethodu")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

        class MethodNameAttribute : Attribute
        {
            public MethodNameAttribute(string name)
            {

            }
        }



    }
}
