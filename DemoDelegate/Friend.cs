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

		public Friend(string name)
		{
			Name = name;
		}

		//	Nhận sự kiện từ Family
		public void ReceiveNotify(Family family)
        {
			family.CallToNotify+= Visit;
        }

		//	Thông báo bạn có thể ghé thăm
		public void Visit()
        {
			Console.Write($"The baby was born. {this.Name} can visit\n");
        }
	}
}
