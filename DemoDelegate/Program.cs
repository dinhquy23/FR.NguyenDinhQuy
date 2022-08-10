using System;

namespace DemoDelegate
{
    public class Program
    {
        public delegate void MyFamilyEventHandler(object sender, EventArgs e);
        private static void Main(string[] args)
        {
			//create new family:
			Family family = new Family("Adams");

			//create a friend:
			Friend Ed = new Friend("Ed");

			//assign the family to the friend:
			Ed.Family = family;

			//create another friend:
			Friend Alex = new Friend("Alex");

			//assign the family to the friend:
			Alex.Family = family;

            //baby is born
            family.BabyBorn();

            Console.Read();
		}
    }
    

}
