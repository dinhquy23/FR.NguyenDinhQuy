using System;
using System.Text;

namespace TestString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string str="";
            string str1="Nguyễn Đình";
            string str2 = "quý";
            string str3 = "Quý";
            string str4 = "Đại học Công Nghiệp Hà Nội";
            string str5 = " Quý ";
            //
            Console.Write($"So sánh str2 va str3 : ");
            Console.Write($"{String.Compare(str2, str3)}");
            Console.Write($"\nSo sánh str2 va str3 sau khi sử dụng toUpper và toLower: ");
            Console.Write($"{String.Compare(str2.ToLower(), str3.ToLower())}    {String.Compare(str2.ToUpper(), str3.ToUpper())}");
            Console.Write($"\nNối str1 và str3: {String.Concat(str1, str3)}");
            Console.Write($"\nTìm kiếm vị trí đầu tiên của ký tự 'i' trong chuỗi str4: {str4.IndexOf('i')}");
            Console.Write($"\nTìm kiếm vị trí cuối cùng của ký tự 'i' trong chuỗi str4: {str4.LastIndexOf('i')}");
            Console.Write($"\nChèn chuỗi str3 vào đầu chuỗi str4:   {str4.Insert(0, str3+" ")}");
            Console.Write($"\nKiểm tra chuỗi str có null hay không: {String.IsNullOrEmpty(str)}");
            Console.Write($"\nCắt chuỗi str4 sử dụng Split: ");
            string[] strArray = str4.Split(' ');
            foreach(var item in strArray)
            {
                Console.Write($"{item}  ,");
            }
            Console.Write($"\nĐộ dài chuỗi str5 trước khi bỏ khoảng trắng: {str5.Length}");
            Console.Write($"\nLoại bỏ khoảng trắng trong chuỗi str5: {str5.Trim()}");
            str5 = str5.Trim();
            Console.Write($"\nĐộ dài chuỗi str5 sau khi bỏ khoảng trắng: {str5.Length}");

            Console.ReadKey();
        }
    }
}
