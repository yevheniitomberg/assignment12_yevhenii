using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment12_yevhenii
{
    internal class ProductionWorker : Employee
    {

        private Shift shift { get; set; }
        private double hourlyPayRate { get; set; }

        public ProductionWorker(string name, int number, Shift shift, double hourlyPayRate) : base(name, number)
        {
            this.shift = shift;
            this.hourlyPayRate = hourlyPayRate;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("ProductionWorker[shift={0}, hourlyPayRate={1}]", shift, hourlyPayRate);
        }

    }
}
