using System;

namespace IF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine($"Nhap he so a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine($"Nhap he so b: ");
            b=double.Parse(Console.ReadLine());
            Console.WriteLine($"Nhap he so c: ");
            c=double.Parse(Console.ReadLine());
            GiaiPTB2(a, b, c);
            Console.ReadKey();
        }

        private static void GiaiPTB2(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            if(a==0)
            {
                Console.WriteLine($"Day khong phai phuong trinh bac 2");

            }
            else
            {
                if(delta<0)
                {
                    Console.WriteLine($"Phuong trinh vo nghiem");
                }
                else if(delta==0)
                {
                    Console.WriteLine($"Phuong trinh co nghiep kep x= {-b / (2 * a)}");
                }
                else
                {
                    Console.WriteLine($"Phuong trinh co 2 nghiem phan biet x1= {(-b + Math.Sqrt(delta)) / (2 * a)}, x2= {(-b - Math.Sqrt(delta)) / (2 * a)}");
                }
            }
        }
    }
}
