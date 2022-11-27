using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment12_yevhenii
{
    internal class Employee
    {
        private string name { get; set; }
        private int number { get; set; }

        public Employee(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        public override string ToString()
        {
            return string.Format("Employee[name={0}, number={1}] --> ", name, number);
        }
    }
}
