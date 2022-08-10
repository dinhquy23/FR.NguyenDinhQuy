using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DemoDelegate.Program;

namespace DemoDelegate
{
    public class Family
    {
        public event MyFamilyEventHandler OnBabyBorn;
        public string Name { get; set; }

        public Family(string name)
        {
            Name = name;
        }
        public void BabyBorn()
        {
            if (OnBabyBorn!=null)
            {
                OnBabyBorn(Name, new EventArgs());
            }
        }
    }
}
