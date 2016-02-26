using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1._3
{
    class Billing
    {
        public void CarParked(Car ParkedCar)
        {
            Console.WriteLine($"New bill for an {ParkedCar.GetModel()}.");
        }
    }
}
