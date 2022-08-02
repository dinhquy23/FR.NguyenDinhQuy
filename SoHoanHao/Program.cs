using System;
using System.Collections.Generic;

namespace SoHoanHao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine($"Nhap so: ");
            number = int.Parse(Console.ReadLine());

            CheckNumber(number);

            Console.ReadLine();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        private static void CheckNumber(int number)
        {
            List<int> dsUoc = new List<int>();
            int Sum = 0;
            if(number<=0)
            {
                Console.WriteLine($"So khong phu hop");
            }
            else
            {
                for(int i = 1; i < number; i++)
                {
                    if(number%i==0)
                    {
                        dsUoc.Add(i);
                        Sum += i;
                    }
                }
                if(Sum==number)
                {
                    Console.WriteLine($"Day la so hoan hao");
                }
                else
                {
                    Console.WriteLine($"Day khong phai so hoan hao");
                }
            }
        }
    }
}
