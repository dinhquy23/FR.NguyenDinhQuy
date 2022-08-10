using System;
using System.Text.RegularExpressions;

namespace DemoTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string password = string.Empty;
            //Console.WriteLine("Nhap password: ");
            //password = Console.ReadLine();

            int number = 0, Sum = 20;
            try
            {
                //Console.WriteLine("Nhap number: ");
                //number = int.Parse(Console.ReadLine());
                //Sum = 100 / number;
                throw new Exception("Day la throw exception");
            }
            finally
            {
                Console.WriteLine("Day la ket qua cuoi cung cua Sum : ", Sum);
            }
            //try
            //{
            //    CheckEmail(password);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Console.ReadKey();





        }
        //public static void CheckEmail(string password)
        //{
        //    if (password.Length>8)
        //    {
        //        Console.WriteLine("Password hop le");
        //    }
        //    else
        //    {
        //        throw new Exception("Password is invalid !");
        //    }
        //}

    }
}

