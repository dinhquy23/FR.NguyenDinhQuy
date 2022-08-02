using System;

namespace Fibonaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine($"Nhap so n: ");
            n=int.Parse(Console.ReadLine());
            DisplayFibonaci(n);
            Console.ReadKey();
        }

        private static void DisplayFibonaci(int n)
        {
            if(n==1)
            {
                Console.WriteLine($"1");
            }
            else if(n==2)
            {
                Console.WriteLine($"1,  1");
            }
            else
            {
                for(int i = 0; i < n; i++)
                {

                }
            }
        }
    }
}
