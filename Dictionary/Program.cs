using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // koleksiyonun oluşturulması
            Dictionary<int,string> myDictionary = new Dictionary<int,string>();
            //değerlerin eklenmesi
            myDictionary.Add(1, "Yunus");
            myDictionary.Add(2, "Yagmur");
            myDictionary.Add(3, "Emir");


            foreach (KeyValuePair<int,string> item in myDictionary)
            {
                Console.WriteLine("{0} {1}",
                    item.Key, item.Value);
            }


            // koleksiyonun oluşturulması ve aynı zamanda değerlerin eklenmesi
            Dictionary<string,string> myDictionary2 = new Dictionary<string, string>(){ { "1-Its a", "Dog"},{ "2-Its a", "Frog"},{ "3-Its a", "Cat"} };


            foreach (KeyValuePair<string,string> item in myDictionary2)
            {
                Console.WriteLine("{0} {1}", 
                    item.Key, item.Value);
            }
        }
    }
}
