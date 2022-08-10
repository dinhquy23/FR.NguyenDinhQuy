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
		private Family _family;

		public Family Family
		{
			get
			{
				return _family;
			}
			set
			{
				_family = value;
				_family.OnBabyBorn += new MyFamilyEventHandler(family_OnBabyBorn);
			}
		}

		public string Name { get; set; }

		public Friend(string name)
		{
			Name = name;
		}

		void family_OnBabyBorn(object sender, EventArgs e)
		{
			Console.WriteLine("{0}, go visit {1} family", Name, sender.ToString());
		}
	}
}
