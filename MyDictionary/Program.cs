using System;
using System.Collections.Generic;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> dictionary = new Dictionary<int, string>() { { 1, "yunus" }, {2, "yagmur" }, { 3, "emir"} };
            foreach(KeyValuePair<int,string> item in dictionary)
            {
                Console.WriteLine("{0}, {1}",  item.Key, item.Value);
            }







            MyDictionary<int,string> customers = new MyDictionary<int,string>();
            customers.Add(1, "Yunus");
            customers.Add(2, "Yagmur");
            customers.Add(3, "Emir");

            for (int i = 0; i < customers.Keys.Length; i++)
            {
                Console.WriteLine("{0}, {1}", customers.Keys[i], customers.Values[i]);
            }

            //foreach (KeyValuePair<int,string> item in customers)
            //{

            //}


        }
    }

    class MyDictionary<K, V>
    {
        K[] _keys;
        V[] _values;

        public MyDictionary()
        {
            _keys = new K[0];
            _values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] _tempKeyArray = _keys;
            V[] _tempValueArray = _values;

            _keys = new K[_keys.Length+1];
            _values = new V[_keys.Length+1];

            for (int i = 0; i < _tempKeyArray.Length; i++)
            {
                _keys[i] = _tempKeyArray[i];
            }
            _keys[_keys.Length - 1] = key;

            for (int i = 0; i < _tempValueArray.Length; i++)
            {
                _values[i] = _tempValueArray[i];
            }
            _values[_keys.Length - 1] = value;
        }

        public K[] Keys
        {
            get { return _keys; }
        }

        public V[] Values
        {
            get { return _values; }
        }



    }
}
