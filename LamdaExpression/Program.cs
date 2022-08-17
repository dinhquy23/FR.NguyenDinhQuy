using System;

namespace LamdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Service service = new Service();

            Console.Write("List Employee have ID>10\n");
            service.Method1();
            Console.Write("List Employee have ID>10 and Name start with 'C'\n");
            service.Method2();
            Console.Write("The first Employee have year of birth is 1992\n");
            service.Method3();
        }
    }
}
