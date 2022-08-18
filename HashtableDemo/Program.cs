using System;
using System.Collections;

namespace HashtableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable MyHash1 = new Hashtable();
            Hashtable MyHash2 = new Hashtable(5);
            //creating a Hashtable using collection-initializer syntax
            var HashCities = new Hashtable(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
                };


            //Add(object Key, object Value) // Key khong duoc trung nhau, value co the trung nhau
            MyHash2.Add("K", "Kvalue");
            MyHash2.Add("H", 123);
            MyHash2.Add(1, "String");
            MyHash2.Add(2, 123);  // MyHash2.Add(1, 123) sai vi Key bi trung
            MyHash1.Add(3, "KKKK");
            //Khoi tao bang :
            Hashtable MyHash3 = new Hashtable(MyHash2);

            //method Clear
            MyHash2.Clear();

            //
            Console.WriteLine("MyHash3: ");
            foreach (DictionaryEntry item in MyHash3)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }

            //Clone method:
            Hashtable CloneHash = new Hashtable();
            CloneHash = (Hashtable)MyHash3.Clone();
            CloneHash.Remove(3);
            Console.WriteLine("CloneHash: ");
            foreach (DictionaryEntry item in CloneHash)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }

            Console.WriteLine("\nMyHash3.ContainsKey(2) return " + MyHash3.ContainsKey(2));
            Console.WriteLine("\nMyHash3.ContainsValue(\"String\") return " + MyHash3.ContainsValue("String"));


            object[] arr = new object[10];
            MyHash3.CopyTo(arr, 5);

            Console.WriteLine("\nArray Copied from MyHash3");

            foreach (Object item in arr)
            {
                if (item != null)
                {
                    DictionaryEntry dE = (DictionaryEntry)item;
                    Console.WriteLine(dE.Key + "\t" + dE.Value);
                }
                else
                    Console.WriteLine("Thang nay bang null");

            }
            Console.ReadKey();

        }
    }
}
