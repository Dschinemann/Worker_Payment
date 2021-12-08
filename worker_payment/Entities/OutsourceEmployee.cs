using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worker_payment.Entities
{
     class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; private set; }

        public OutsourceEmployee() { }
        public OutsourceEmployee(double additionalCharge, string name, int hours, double valuePerHour) :base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }        

        public override double Payment()
        {
            double sum = base.Payment() + 1.1 * AdditionalCharge;
            return sum;

        }
    }
}
