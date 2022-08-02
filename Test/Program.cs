using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 7, 2, 4, 1, 6 };
            for(int i = 0; i < a.Length-1; i++)
            {
                for(int j=i+1; j<a.Length; j++)
                {
                    if (a[j] < a[i])
                    {
                        int temp;
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "    ");
            }
            Console.ReadLine();
        }
    }
}
