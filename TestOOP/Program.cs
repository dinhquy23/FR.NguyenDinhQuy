using System;

namespace TestOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            A d = new C();
            A e = new B();

            B f = new C();
            //B g=new A();
            a.Show();
            b.Show();
            c.Show();
            d.Show();
            e.Show();
            f.Show();
            //a = (B)a;
            //c = new B();
            ////b = new A();
            //Console.WriteLine("----------------------");
            //a.Show();
            //c.Show();
            Console.ReadLine();
        }
    }
}
