using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public Employee() { }
        public Employee(int iD, string name, DateTime dateTime)
        {
            ID = iD;
            Name = name;
            Birthday = dateTime;
        }
        public override string ToString()
        {
            return $"{ID,5}    {Name,10}   {Birthday.ToShortDateString(),10}";
        }
    }
}
