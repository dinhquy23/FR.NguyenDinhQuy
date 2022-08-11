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
			family.CallToNotify+= GetNotify;
        }

		//	Thông báo sẽ ghé thăm
		public void GetNotify()
        {
			Console.Write($"{this.Name} will visit\n");
        }
	}
}
