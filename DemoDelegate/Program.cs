using System;
using System.Collections.Generic;

namespace DemoDelegate
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Family family = new Family("Van A");

            List<Friend> listFriends = new()
            {
                new Friend("Nguyen Van B",true),
                new Friend("Nguyen Van C",false),
                new Friend("Nguyen Van D",true),
                new Friend("Nguyen Thi E",true)
            };

            foreach (var item in listFriends)
            {
                if (item.Register)
                {
                    //  Nếu bạn đã đăng ký tới thăm, bạn sẽ nhận được thông báo từ gia đình ngay khi đứa trẻ được sinh ra
                    item.ReceiveNotify(family);
                }
            }

            //  Sự kiện đứa trẻ sinh ra
            family.BabyBorn();

            Console.ReadLine();
        }
    }


}
