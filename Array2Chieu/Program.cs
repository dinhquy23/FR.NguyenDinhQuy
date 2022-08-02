using System;

namespace Array2Chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine($"Nhap so hang: ");
            m=int.Parse(Console.ReadLine());
            Console.WriteLine($"Nhap so cot: ");
            n=int.Parse(Console.ReadLine());
            int[,] Array1 = new int[m,n];
            NhapMangHaiChieu(Array1, m, n);
            Console.WriteLine($"Mang hai chieu vua nhap: ");
            HienThiMangHaiChieu(Array1);
            //Console.WriteLine($"{Array1.GetLength(0)}");
            //Console.WriteLine($"{Array1.Length}");
            //Console.WriteLine($"{Array1.Rank}");
            Console.ReadKey();

        }

        private static void HienThiMangHaiChieu(int[,] array1)
        {
            for (int i = 0; i < (array1.Length/array1.GetLength(0)); i++)
            {
                for (int j = 0; j < array1.GetLength(0); j++)
                {
                    Console.Write($"{array1[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void NhapMangHaiChieu(int[,] array,int m,int n)
        {
            for(int i=0; i < m; i++)
            {
                for(int j=0; j < n; j++)
                {
                    Console.Write($"Array[{i},{j}]= ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
