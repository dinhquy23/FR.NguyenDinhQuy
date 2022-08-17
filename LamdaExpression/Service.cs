using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    public class Service
    {
        private readonly static List<Employee> employees =new List<Employee>();
        static Service()
        {
            employees = new List<Employee>()
            {
                new Employee(1,"Quy",new DateTime(1999,12,23)),
                new Employee(11,"Quang",new DateTime(2000,01,02)),
                new Employee(21,"Linh",new DateTime(2001,11,15)),
                new Employee(13,"Hai",new DateTime(1992,05,23)),
                new Employee(2,"Nam",new DateTime(2000,12,25)),
                new Employee(3,"Duc",new DateTime(2002,07,23)),
                new Employee(33,"Cuong",new DateTime(2000,03,15)),
                new Employee(14,"Viet",new DateTime(1992,10,11)),
                new Employee(26,"Cong",new DateTime(1999,01,10)),
                new Employee(15,"Tuan",new DateTime(2001,12,25))
            };
        }

        public void Method1()
        {
            var results = employees.Where(x => x.ID > 10);
            foreach(var item in results)
            {
                Console.Write($"{item.ToString()}\n");
            }
        }
        public void Method2()
        {
            var results = employees.Where(x => x.ID > 10&&x.Name.StartsWith('C'));
            foreach (var item in results)
            {
                Console.Write($"{item.ToString()}\n");
            }
        }
        public void Method3()
        {
            try
            {
                var result = employees.FirstOrDefault(x => x.Birthday.Year == 1992);
                Console.Write($"{result.ToString()}\n");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
