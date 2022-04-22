using System;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            Console.WriteLine(sehirler.Count);

            List<int> plakalar = new List<int>();
            //MyList sehirler2 = new MyList();


            MyList<int> plakalar2 = new MyList<int>();
            plakalar.Add(1);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Eskişehir");
            sehirler2.Add("Eskişehir");
            sehirler2.Add("Eskişehir");
            sehirler2.Add("Eskişehir");
            sehirler2.Add("Eskişehir");
            sehirler2.Add("Eskişehir");
            Console.WriteLine(sehirler2.Count);
            
        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
                _array = new T[0];
        }
         public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for(int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length-1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }

    }
}
