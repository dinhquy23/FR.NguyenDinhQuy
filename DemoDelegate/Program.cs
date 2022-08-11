using System;

namespace DemoDelegate
{
    public class Program
    {
        private static void Main(string[] args)
        {
			Family family = new Family("Adams");

            Friend friend1 = new Friend("Nguyen Van A");
            Friend friend2 = new Friend("Nguyen Van B");
            Friend friend3 = new Friend("Nguyen Van C");
            Friend friend4 = new Friend("Nguyen Van D");

            //  Đăng ký nhận thông báo
            friend1.ReceiveNotify(family);
            friend2.ReceiveNotify(family);
            friend4.ReceiveNotify(family);

            //  Sự kiện đứa trẻ sinh ra
            family.BabyBorn();

            Console.ReadLine();
		}
    }
    

}
