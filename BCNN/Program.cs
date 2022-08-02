using System;

namespace BCNN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, UCLL=1;
            int BCNN;
            Console.WriteLine($"Nhap so thu nhat: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Nhap so thu hai: ");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                c = b;
            }
            else
            {
                c = a;
            }
            for (int i = c - 1; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    UCLL = i;
                    break;
                }
            }
            BCNN = (a * b) / UCLL;
            Console.WriteLine($"BCNN cua 2 so la: {BCNN}");
            Console.ReadLine();
        }
    }
}
