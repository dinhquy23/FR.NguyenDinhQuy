using System;
using System.Globalization;

namespace DemoDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  Các cách khai báo DateTime hay dùng
            DateTime dateTime  = new DateTime();
            DateTime dateTime1 = new DateTime(2021, 07, 25, 10, 59, 25);
            DateTime dateTime2 = new DateTime(2022, 07, 26);
            DateTime dateTime3 = new DateTime(2022, 07, 25, 10, 59, 25);

            //  các phương thức hay sử dụng của DateTime
            Console.WriteLine($"Ngay {dateTime2} là {dateTime2.DayOfWeek}");
            Console.WriteLine($"Ngay {dateTime2} la ngay thu {dateTime2.DayOfYear} cua nam {dateTime2.Year}");
            Console.WriteLine(dateTime2.AddMonths(1).ToShortDateString());

            //  Thao tác với TimeSpan
            TimeSpan timeSpan = dateTime3 - dateTime1;
            Console.WriteLine($"Khoang thoi gian giua {dateTime3} va {dateTime2} la {timeSpan.TotalDays} ngay");
            Console.WriteLine($"Khoang thoi gian giua {dateTime3} va {dateTime2} la {timeSpan.TotalHours} gio");
            Console.WriteLine($"Khoang thoi gian giua {dateTime3} va {dateTime2} la {timeSpan.TotalMinutes} ngay");
            Console.WriteLine($"Khoang thoi gian giua {dateTime3} va {dateTime2} la {timeSpan.TotalSeconds} giay");
            Console.WriteLine($"Khoang thoi gian giua {dateTime3} va {dateTime2} la {timeSpan.TotalMilliseconds} mili giay");
            Console.WriteLine(dateTime2.Add(timeSpan).ToString());

            if (dateTime2 > dateTime1)
            {
                Console.WriteLine($"Datetime 2 lon hon Datetime3");
            }
            else
            {
                Console.WriteLine($"Datetime 2 nho hon Datetime3");
            }

            // Bài toán tính số ngày thứ 7 và chủ nhật của một tháng nhập từ bàn phím
            DateTime dateTime4;
            Console.WriteLine($"Nhap vao thang va nam(MM/yyyy): ");
            dateTime4 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Thang {dateTime4.Month} nam {dateTime4.Year} co {CheckNgayNghiMotThang(dateTime4)} ngay nghi");
            Console.ReadKey();
        }
        /// <summary>
        /// Phương thức trả về số ngày thứ 7 và chủ nhật của một tháng
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns>Trả về dữ liệu kiểu int là số ngyà thứ 7 và chủ nhật của một tháng</returns>
        private static int CheckNgayNghiMotThang(DateTime dateTime)
        {
            int ngayNghi = 0;
            for (DateTime i = dateTime; i < dateTime.AddMonths(1); i = i.AddDays(1))
            {
                if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
                {
                    ngayNghi++;
                }
            }
            return ngayNghi;
        }
    }
}
