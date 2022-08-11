using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DemoDelegate.Program;

namespace DemoDelegate
{
    public delegate void Notify();
    public class Family
    {
        public Notify CallToNotify { get; set; }
        public string Name { get; set; }

        public Family(string name)
        {
            Name = name;
        }
        public void BabyBorn()
        {
            //  Phát đi sự kiện
            CallToNotify?.Invoke();
        }
    }
}
