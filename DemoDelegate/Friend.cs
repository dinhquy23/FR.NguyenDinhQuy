using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DemoDelegate.Program;

namespace DemoDelegate
{
    public class Friend
    {
		public string Name { get; set; }

        public bool Register { get; set; }

        public Friend(string name, bool register)
        {
            Name = name;
            Register = register;
        }

        //	Nhận sự kiện từ Family qua hành động CallToNotify (gia đình gọi điện thông báo) và thực hiện hành động Visit() để ghé thăm
        public void ReceiveNotify(Family family)
        {
			family.CallToNotify += Visit;
        }

		//	Thông báo bạn có thể ghé thăm
		public void Visit()
        {
			Console.Write($"The baby was born. {this.Name} can visit\n");
        }
	}
}
