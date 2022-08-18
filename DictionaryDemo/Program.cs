using System;
using System.Collections.Generic;
namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> MyDic0 = new Dictionary<string, string>();
            Dictionary<string, string> MyDic1 = new Dictionary<string, string>(5);

            MyDic1.Add("J", "Joker");
            MyDic1.Add("Q", "Queen");
            MyDic1.Add("K", "King");
            MyDic1.Add("A", "Archer");

            Dictionary<string, string> MyDic = new Dictionary<string, string>(MyDic1);
            //method Clear
            MyDic1.Clear();

            //
            Console.WriteLine("MyDic before remove: ");
            foreach (KeyValuePair<string, string> item in MyDic)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }

            Console.WriteLine("\nMyDic.ContainsKey(2) return " + MyDic.ContainsKey("K"));
            Console.WriteLine("MyDic.ContainsValue(\"String\") return " + MyDic.ContainsValue("King"));

            MyDic.Remove("A");
            Console.WriteLine("\nMyDic after remove: ");
            foreach (KeyValuePair<string, string> item in MyDic)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            string ReturnValue;
            Console.WriteLine("\nTryGetValue return " + MyDic.TryGetValue("K", out ReturnValue));
            Console.WriteLine("TryGetValue make ReturnValue = " + ReturnValue);
            Console.ReadKey();
        }
    }
}
